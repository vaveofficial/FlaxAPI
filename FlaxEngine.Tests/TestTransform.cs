using System;
using FlaxEngine.Utilities;
using NUnit.Framework;

namespace FlaxEngine.Tests
{
	/// <summary>
	/// Tests for <see cref="Transform"/>.
	/// </summary>
	[TestFixture]
	public class TestTransform
	{
		/// <summary>
		/// Test transformation matrix calculation.
		/// </summary>
		[Test]
		public void TestWorldMatrix()
		{
			Transform t1 = new Transform(new Vector3(10, 1, 10), Quaternion.Euler(45, 0, -15), new Vector3(1.5f, 0.5f, 0.1f));

			Matrix a1 = t1.GetWorld();

			Matrix a2;
			{
				Matrix m1, m2;
				Matrix.Scaling(ref t1.Scale, out a2);
				Matrix.RotationQuaternion(ref t1.Orientation, out m2);
				Matrix.Multiply(ref a2, ref m2, out m1);
				Matrix.Translation(ref t1.Translation, out m2);
				Matrix.Multiply(ref m1, ref m2, out a2);
			}

			Matrix a3;
			Matrix.Transformation(ref t1.Scale, ref t1.Orientation, ref t1.Translation, out a3);

			Assert.AreEqual(a1, a2);
			Assert.AreEqual(a1, a3);
		}

		/// <summary>
		/// Tests the local space to world space conversion.
		/// </summary>
		[Test]
		public void TestLocalToWorld()
		{
			Transform t1 = new Transform(new Vector3(10, 1, 10), Quaternion.Euler(45, 0, -15), new Vector3(1.5f, 0.5f, 0.1f));
			Transform t2 = new Transform(new Vector3(0, 20, 0), Quaternion.Euler(0, 0, 15), new Vector3(1.0f, 2.0f, 1.0f));

			Transform a1 = t1.LocalToWorld(t2);
			Vector3 a2 = t1.LocalToWorld(t2.Translation);

			Vector3 a3;
			{
				Vector3 result;
				Matrix scale, rotation, scaleRotation;
				Matrix.Scaling(ref t1.Scale, out scale);
				Matrix.RotationQuaternion(ref t1.Orientation, out rotation);
				Matrix.Multiply(ref scale, ref rotation, out scaleRotation);
				Vector3.Transform(ref t2.Translation, ref scaleRotation, out result);
				a3 = result + t1.Translation;
			}

			var a4T = new Vector3[1];
			t1.LocalToWorld(new Vector3[1] { t2.Translation }, a4T);
			Vector3 a4 = a4T[0];

			Assert.AreEqual(a1.Translation, a2);
			Assert.AreEqual(a2, a3);
			Assert.AreEqual(a2, a4);
		}

		/// <summary>
		/// Tests the world space to local space conversion.
		/// </summary>
		[Test]
		public void TestWorldToLocal()
		{
			Transform t1 = new Transform(new Vector3(10, 1, 10), Quaternion.Euler(45, 0, -15), new Vector3(1.5f, 0.5f, 0.1f));
			Transform t2 = new Transform(new Vector3(0, 20, 0), Quaternion.Euler(0, 0, 15), new Vector3(1.0f, 2.0f, 1.0f));

			Transform a1 = t1.WorldToLocal(t2);
			Vector3 a2 = t1.WorldToLocal(t2.Translation);

			Vector3 a3;
			{
				Matrix scale, rotation, scaleRotation;
				Matrix.Scaling(ref t1.Scale, out scale);
				Matrix.RotationQuaternion(ref t1.Orientation, out rotation);
				Matrix.Multiply(ref scale, ref rotation, out scaleRotation);
				Matrix.Invert(ref scaleRotation, out scale);
				a3 = t2.Translation - t1.Translation;
				Vector3.Transform(ref a3, ref scale, out a3);
			}

			var a4T = new Vector3[1];
			t1.WorldToLocal(new Vector3[1] { t2.Translation }, a4T);
			Vector3 a4 = a4T[0];

			Assert.AreEqual(a1.Translation, a2);
			Assert.AreEqual(a2, a3);
			Assert.AreEqual(a2, a4);
		}

		/// <summary>
		/// Test conversions between transform local/world space
		/// </summary>
		[Test]
		public void TestWorldAndLocalSpace()
		{
			Transform trans = new Transform(new Vector3(1, 2, 3));

			Assert.AreEqual(new Vector3(1, 2, 3), trans.LocalToWorld(new Vector3(0, 0, 0)));
			Assert.AreEqual(new Vector3(4, 4, 4), trans.LocalToWorld(new Vector3(3, 2, 1)));
			Assert.AreEqual(new Vector3(-1, -2, -3), trans.WorldToLocal(new Vector3(0, 0, 0)));
			Assert.AreEqual(new Vector3(0, 0, 0), trans.WorldToLocal(new Vector3(1, 2, 3)));

			trans = new Transform(Vector3.Zero, Quaternion.Euler(0, 90, 0));
			Assert.AreEqual(new Vector3(0, 2, -1), trans.LocalToWorld(new Vector3(1, 2, 0)));

			trans.Translation = new Vector3(1, 0, 0);
			trans.Orientation = Quaternion.RotationX((float)Math.PI * 0.5f);
			trans.Scale = new Vector3(2, 2, 2);
			Assert.AreEqual(new Vector3(1, 0, 2), trans.LocalToWorld(new Vector3(0, 1, 0)));

			Transform t1 = trans.LocalToWorld(Transform.Identity);
			Assert.AreEqual(new Vector3(1.0f, 0, 0), t1.Translation);
			Assert.AreEqual(Quaternion.RotationX((float)Math.PI * 0.5f), t1.Orientation);
			Assert.AreEqual(new Vector3(2.0f, 2.0f, 2.0f), t1.Scale);

			Transform t2 = trans.WorldToLocal(Transform.Identity);
			Assert.AreEqual(new Vector3(-0.5f, 0, 0), t2.Translation);
			Assert.AreEqual(Quaternion.RotationX((float)Math.PI * -0.5f), t2.Orientation);
			Assert.AreEqual(new Vector3(0.5f, 0.5f, 0.5f), t2.Scale);

			var rand = new Random(10);
			for (int i = 0; i < 10; i++)
			{
				Transform a = new Transform(rand.NextVector3(), Quaternion.Euler(i * 10, 0, i), rand.NextVector3() * 10.0f);
				Transform b = new Transform(rand.NextVector3(), Quaternion.Identity, rand.NextVector3() * 0.3f);

				Transform ab = a.LocalToWorld(b);
				Transform ba = a.WorldToLocal(ab);

				Assert.AreEqual(b, ba);
			}
		}
	}
}
