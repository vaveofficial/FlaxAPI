// Copyright (c) 2012-2019 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
    /// <summary>
    /// A base class for all colliders.
    /// </summary>
    [Serializable]
    public abstract partial class Collider : Actor
    {
        /// <summary>
        /// Gets or sets the 'IsTrigger' flag.
        /// </summary>
        /// <remarks>
        /// A trigger doesn't register a collision with an incoming Rigidbody. Instead, it sends OnTriggerEnter, OnTriggerExit and OnTriggerStay message when a rigidbody enters or exits the trigger volume.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(0), DefaultValue(false), EditorDisplay("Collider"), Tooltip("Check if use collider shape to detect objects or turn if off to collide with others")]
        public bool IsTrigger
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetIsTrigger(unmanagedPtr); }
            set { Internal_SetIsTrigger(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the center of the collider, measured in the object's local space.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(10), DefaultValue(typeof(Vector3), "0,0,0"), EditorDisplay("Collider"), Tooltip("Center point of the collider in the actor local space")]
        public Vector3 Center
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { Vector3 resultAsRef; Internal_GetCenter(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetCenter(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the contact offset.
        /// </summary>
        /// <remarks>
        /// Colliders whose distance is less than the sum of their ContactOffset values will generate contacts. The contact offset must be positive. Contact offset allows the collision detection system to predictively enforce the contact constraint even when the objects are slightly separated.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(1), DefaultValue(10.0f), Limit(0, 100), EditorDisplay("Collider"), Tooltip("Determinates distance for detecting contacts with other colliders.")]
        public float ContactOffset
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetContactOffset(unmanagedPtr); }
            set { Internal_SetContactOffset(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the physical material used by this collider.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(2), DefaultValue(null), AssetReference(typeof(PhysicalMaterial), true), EditorDisplay("Collider"), Tooltip("The physical material used by this collider.")]
        public JsonAsset Material
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetMaterial(unmanagedPtr); }
            set { Internal_SetMaterial(unmanagedPtr, Object.GetUnmanagedPtr(value)); }
#endif
        }

        /// <summary>
        /// Gets the attached rigidbody.
        /// </summary>
        [UnmanagedCall]
        [HideInEditor]
        public RigidBody AttachedRigidBody
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetAttachedRigidBody(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Computes minimum translational distance between two geometry objects. Translating the first collider by direction * distance will separate the colliders apart if the function returned true. Otherwise, direction and distance are not defined. The one of the colliders has to be BoxCollider, SphereCollider CapsuleCollider or a convex MeshCollider. The other one can be any type.
        /// </summary>
        /// <param name="colliderA">The first collider.</param>
        /// <param name="colliderB">The second collider.</param>
        /// <param name="direction">The computed direction along which the translation required to separate the colliders apart is minimal. Valid only if function returns true.</param>
        /// <param name="distance">The penetration distance along direction that is required to separate the colliders apart. Valid only if function returns true.</param>
        /// <returns>True if the distance has successfully been computed, i.e. if objects do overlap, otherwise false.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static bool ComputePenetration(Collider colliderA, Collider colliderB, out Vector3 direction, out float distance)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_ComputePenetration(Object.GetUnmanagedPtr(colliderA), Object.GetUnmanagedPtr(colliderB), out direction, out distance);
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_GetIsTrigger(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetIsTrigger(IntPtr obj, bool val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetCenter(IntPtr obj, out Vector3 resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetCenter(IntPtr obj, ref Vector3 val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetContactOffset(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetContactOffset(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern JsonAsset Internal_GetMaterial(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetMaterial(IntPtr obj, IntPtr val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern RigidBody Internal_GetAttachedRigidBody(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_ComputePenetration(IntPtr colliderA, IntPtr colliderB, out Vector3 direction, out float distance);
#endif

        #endregion
    }
}
