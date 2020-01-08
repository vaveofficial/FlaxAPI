// Copyright (c) 2012-2020 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
    /// <summary>
    /// Represents a foliage actor that contains a set of instanced meshes.
    /// </summary>
    [Serializable]
    public sealed partial class Foliage : Actor
    {
        /// <summary>
        /// Creates new <see cref="Foliage"/> object.
        /// </summary>
        private Foliage() : base()
        {
        }

        /// <summary>
        /// Creates new instance of <see cref="Foliage"/> object.
        /// </summary>
        /// <returns>Created object.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static Foliage New()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_Create(typeof(Foliage)) as Foliage;
#endif
        }

        /// <summary>
        /// Gets or sets the global density scale for all foliage instances. The default value is 1. Use values from range 0-1. Lower values decrease amount of foliage instances in-game. Use it to tweak game performance for slower devices.
        /// </summary>
        [UnmanagedCall]
        public static float GlobalDensityScale
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GlobalDensityScale(); }
            set { Internal_SetGlobalDensityScale(value); }
#endif
        }

        /// <summary>
        /// Gets the total amount of foliage instances added to the actor.
        /// </summary>
        [UnmanagedCall]
        public int InstancesCount
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetInstancesCount(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets the foliage instance data.
        /// </summary>
        /// <param name="index">The zero-based index of the foliage instance.</param>
        /// <param name="value">The result instance data.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void GetInstance(int index, out Instance value)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_GetInstance(unmanagedPtr, index, out value);
#endif
        }

        /// <summary>
        /// Sets the foliage instance data (the transform only).
        /// </summary>
        /// <param name="index">The zero-based index of the foliage instance.</param>
        /// <param name="value">The instance data.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void SetInstance(int index, ref Instance value)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_SetInstance(unmanagedPtr, index, ref value);
#endif
        }

        /// <summary>
        /// Adds the foliage instance. After adding/removing foliage instances always call <see cref="RebuildClusters"/> to prepare internal acceleration structures.
        /// </summary>
        /// <remarks>
        /// Input instance bounds are ignored (recalculated).
        /// </remarks>
        /// <param name="value">The instance data.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void AddInstance(ref Instance value)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_AddInstance(unmanagedPtr, ref value);
#endif
        }

        /// <summary>
        /// Removes the foliage instance. After adding/removing foliage instances always call <see cref="RebuildClusters"/> to prepare internal acceleration structures.
        /// </summary>
        /// <param name="index">The zero-based index of the foliage instance.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void RemoveInstance(int index)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_RemoveInstance(unmanagedPtr, index);
#endif
        }

        /// <summary>
        /// Gets the amount of foliage instance types defined for the given foliage actor.
        /// </summary>
        [UnmanagedCall]
        public int FoliageTypesCount
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetFoliageTypesCount(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets the model assigned to the foliage instance type.
        /// </summary>
        /// <param name="index">The zero-based index of the foliage instance type descriptor.</param>
        /// <returns>The model.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public Model GetFoliageTypeModel(int index)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_GetFoliageTypeModel(unmanagedPtr, index);
#endif
        }

        /// <summary>
        /// Sets the model assigned to the foliage instance type.
        /// </summary>
        /// <param name="index">The zero-based index of the foliage instance type descriptor.</param>
        /// <param name="model">The model to assign. It cannot be null nor already used by the other instance type (it must be unique within the given foliage actor).</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void SetFoliageTypeModel(int index, Model model)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_SetFoliageTypeModel(unmanagedPtr, index, FlaxEngine.Object.GetUnmanagedPtr(model));
#endif
        }

        /// <summary>
        /// Adds the new foliage instance type.
        /// </summary>
        /// <param name="model">The model to assign. It cannot be null nor already used by the other instance type (it must be unique within the given foliage actor).</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void AddFoliageType(Model model)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_AddFoliageType(unmanagedPtr, FlaxEngine.Object.GetUnmanagedPtr(model));
#endif
        }

        /// <summary>
        /// Removes the foliage instance type and all foliage instances using this type.
        /// </summary>
        /// <param name="index">The zero-based index of the foliage instance type descriptor.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void RemoveFoliageType(int index)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_RemoveFoliageType(unmanagedPtr, index);
#endif
        }

        /// <summary>
        /// Gets the total amount of the instanced that use the given foliage type.
        /// </summary>
        /// <param name="index">The zero-based index of the foliage instance type descriptor.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public int GetFoliageTypeInstancesCount(int index)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_GetFoliageTypeInstancesCount(unmanagedPtr, index);
#endif
        }

        /// <summary>
        /// Gets the foliage instance type materials buffer (overrides).
        /// </summary>
        /// <param name="index">The zero-based index of the foliage instance type descriptor.</param>
        /// <param name="value">The array of materials to fill. It must be valid and have size of foliage type model material slots size. When this method returns it contains a set of materials used by the foliage type.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void GetFoliageTypeMaterials(int index, MaterialBase[] value)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_GetFoliageTypeMaterials(unmanagedPtr, index, value);
#endif
        }

        /// <summary>
        /// Sets the foliage instance type materials buffer (overrides).
        /// </summary>
        /// <param name="index">The zero-based index of the foliage instance type descriptor.</param>
        /// <param name="value">The array of materials to set (raw pointers to unmanaged instances). It must be valid and have size of foliage type model material slots size.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void SetFoliageTypeMaterials(int index, IntPtr[] value)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_SetFoliageTypeMaterials(unmanagedPtr, index, value);
#endif
        }

        /// <summary>
        /// Gets the foliage instance type options.
        /// </summary>
        /// <param name="index">The zero-based index of the foliage instance type descriptor.</param>
        /// <param name="value">The result options container.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void GetFoliageTypeOptions(int index, out TypeOptions value)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_GetFoliageTypeOptions(unmanagedPtr, index, out value);
#endif
        }

        /// <summary>
        /// Sets the foliage instance type options.
        /// </summary>
        /// <param name="index">The zero-based index of the foliage instance type descriptor.</param>
        /// <param name="value">The options to set.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void SetFoliageTypeOptions(int index, ref TypeOptions value)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_SetFoliageTypeOptions(unmanagedPtr, index, ref value);
#endif
        }

        /// <summary>
        /// Rebuilds the clusters (quad tree structure).
        /// </summary>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void RebuildClusters()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_RebuildClusters(unmanagedPtr);
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GlobalDensityScale();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetGlobalDensityScale(float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetInstancesCount(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetInstance(IntPtr obj, int index, out Instance value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetInstance(IntPtr obj, int index, ref Instance value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_AddInstance(IntPtr obj, ref Instance value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_RemoveInstance(IntPtr obj, int index);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetFoliageTypesCount(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Model Internal_GetFoliageTypeModel(IntPtr obj, int index);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetFoliageTypeModel(IntPtr obj, int index, IntPtr model);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_AddFoliageType(IntPtr obj, IntPtr model);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_RemoveFoliageType(IntPtr obj, int index);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetFoliageTypeInstancesCount(IntPtr obj, int index);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetFoliageTypeMaterials(IntPtr obj, int index, MaterialBase[] value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetFoliageTypeMaterials(IntPtr obj, int index, IntPtr[] value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetFoliageTypeOptions(IntPtr obj, int index, out TypeOptions value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetFoliageTypeOptions(IntPtr obj, int index, ref TypeOptions value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_RebuildClusters(IntPtr obj);
#endif

        #endregion
    }
}
