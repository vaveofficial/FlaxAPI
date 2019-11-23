// Copyright (c) 2012-2019 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
    /// <summary>
    /// Used to create fogging effects such as clouds but with a density that is related to the height of the fog.
    /// </summary>
    [Serializable]
    public sealed partial class ExponentialHeightFog : Actor
    {
        /// <summary>
        /// Creates new <see cref="ExponentialHeightFog"/> object.
        /// </summary>
        private ExponentialHeightFog() : base()
        {
        }

        /// <summary>
        /// Creates new instance of <see cref="ExponentialHeightFog"/> object.
        /// </summary>
        /// <returns>Created object.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static ExponentialHeightFog New()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_Create(typeof(ExponentialHeightFog)) as ExponentialHeightFog;
#endif
        }

        /// <summary>
        /// Gets or sets the fog density factor.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(10), DefaultValue(0.02f), Limit(0.000001f, 0.8f, 0.001f), EditorDisplay("Exponential Height Fog"), Tooltip("Fog density factor.")]
        public float FogDensity
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetFogDensity(unmanagedPtr); }
            set { Internal_SetFogDensity(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the fog height density factor that controls how the density increases as height decreases. The smaller values produce more visible transition larger.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(20), DefaultValue(0.2f), Limit(0.001f, 2.0f, 0.001f), EditorDisplay("Exponential Height Fog"), Tooltip("The fog height density factor that controls how the density increases as height decreases. The smaller values produce more visible transition larger.")]
        public float FogHeightFalloff
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetFogHeightFalloff(unmanagedPtr); }
            set { Internal_SetFogHeightFalloff(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the color of the fog.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(30), DefaultValue(typeof(Color), "0.448,0.634,1.0"), EditorDisplay("Exponential Height Fog"), Tooltip("Fog color.")]
        public Color FogInscatteringColor
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { Color resultAsRef; Internal_GetFogInscatteringColor(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetFogInscatteringColor(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the maximum opacity of the fog.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(40), DefaultValue(1.0f), Limit(0, 1, 0.001f), EditorDisplay("Exponential Height Fog"), Tooltip("Maximum opacity of the fog.")]
        public float FogMaxOpacity
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetFogMaxOpacity(unmanagedPtr); }
            set { Internal_SetFogMaxOpacity(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the distance from the camera that the fog will start, in world units.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(50), DefaultValue(0.0f), Limit(0), EditorDisplay("Exponential Height Fog"), Tooltip("Distance from the camera that the fog will start, in world units.")]
        public float StartDistance
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetStartDistance(unmanagedPtr); }
            set { Internal_SetStartDistance(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the distance past which scene elements will have no fog applied. Use value 0 to disable it.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(60), DefaultValue(0.0f), Limit(0), EditorDisplay("Exponential Height Fog"), Tooltip("Scene elements past this distance will not have fog applied. Value 0 disables it.")]
        public float FogCutoffDistance
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetFogCutoffDistance(unmanagedPtr); }
            set { Internal_SetFogCutoffDistance(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the light used for Directional Inscattering.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(200), DefaultValue(null), EditorDisplay("Directional Inscattering", "Light"), Tooltip("Directional light actor used for Directional Inscattering.")]
        public DirectionalLight DirectionalInscatteringLight
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetDirectionalInscatteringLight(unmanagedPtr); }
            set { Internal_SetDirectionalInscatteringLight(unmanagedPtr, FlaxEngine.Object.GetUnmanagedPtr(value)); }
#endif
        }

        /// <summary>
        /// Gets or sets the side of the directional inscattering cone.
        /// </summary>
        /// <remarks>
        /// Note: there must be a directional light enabled for Directional Inscattering to be used.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(210), DefaultValue(4.0f), Limit(2, 64, 0.1f), EditorDisplay("Directional Inscattering", "Exponent"), Tooltip("Controls the size of the directional inscattering cone used to approximate inscattering.")]
        public float DirectionalInscatteringExponent
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetDirectionalInscatteringExponent(unmanagedPtr); }
            set { Internal_SetDirectionalInscatteringExponent(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the start distance from the viewer of the directional inscattering.
        /// </summary>
        /// <remarks>
        /// Note: there must be a directional light enabled for Directional Inscattering to be used.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(220), DefaultValue(10000.0f), Limit(0), EditorDisplay("Directional Inscattering", "Start Distance"), Tooltip("Controls the start distance from the viewer of the directional inscattering, which is used to approximate inscattering.")]
        public float DirectionalInscatteringStartDistance
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetDirectionalInscatteringStartDistance(unmanagedPtr); }
            set { Internal_SetDirectionalInscatteringStartDistance(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the color of the directional inscattering.
        /// </summary>
        /// <remarks>
        /// Note: there must be a directional light enabled for Directional Inscattering to be used.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(230), DefaultValue(typeof(Color), "0.25,0.25,0.125"), EditorDisplay("Directional Inscattering", "Color"), Tooltip("Controls the color of the directional inscattering, which is used to approximate inscattering from a directional light.")]
        public Color DirectionalInscatteringColor
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { Color resultAsRef; Internal_GetDirectionalInscatteringColor(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetDirectionalInscatteringColor(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Whether to enable Volumetric fog.
        /// </summary>
        /// <remarks>
        /// Graphics quality settings control the resolution of the fog simulation.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(300), DefaultValue(false), EditorDisplay("Volumetric Fog", "Enable"), Tooltip("Whether to enable Volumetric fog. Graphics quality settings control the resolution of the fog simulation.")]
        public bool VolumetricFogEnable
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetVolumetricFogEnable(unmanagedPtr); }
            set { Internal_SetVolumetricFogEnable(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the value that controls the scattering phase function - how much incoming light scatters in various directions.
        /// </summary>
        /// <remarks>
        /// A distribution value of 0 scatters equally in all directions, while 0.9 scatters predominantly in the light direction. In order to have visible volumetric fog light shafts from the side, the distribution will need to be closer to 0. Range: -0.9-0.9.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(310), DefaultValue(0.2f), Limit(-0.9f, 0.9f, 0.001f), EditorDisplay("Volumetric Fog", "Scattering Distribution"), Tooltip("Controls the scattering phase function - how much incoming light scatters in various directions.")]
        public float VolumetricFogScatteringDistribution
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetVolumetricFogScatteringDistribution(unmanagedPtr); }
            set { Internal_SetVolumetricFogScatteringDistribution(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the height fog particle reflectiveness used by volumetric fog.
        /// </summary>
        /// <remarks>
        /// Water particles in air have an albedo near white, while dust has slightly darker value.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(320), DefaultValue(typeof(Color), "1,1,1,1"), EditorDisplay("Volumetric Fog", "Albedo"), Tooltip("The height fog particle reflectiveness used by volumetric fog. Water particles in air have an albedo near white, while dust has slightly darker value.")]
        public Color VolumetricFogAlbedo
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { Color resultAsRef; Internal_GetVolumetricFogAlbedo(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetVolumetricFogAlbedo(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the light emitted by height fog.
        /// </summary>
        /// <remarks>
        /// This is a density so more light is emitted the further you are looking through the fog. In most cases using a Skylight is a better choice, however, it may be useful in certain scenarios.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(330), DefaultValue(typeof(Color), "0,0,0,1"), EditorDisplay("Volumetric Fog", "Emissive"), Tooltip("Light emitted by height fog. This is a density so more light is emitted the further you are looking through the fog.")]
        public Color VolumetricFogEmissive
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { Color resultAsRef; Internal_GetVolumetricFogEmissive(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetVolumetricFogEmissive(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the scale of the height fog particles extinction.
        /// </summary>
        /// <remarks>
        /// Values larger than 1 cause fog particles everywhere absorb more light. Range: 0.1-10.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(340), DefaultValue(1.0f), Limit(0.1f, 10, 0.1f), EditorDisplay("Volumetric Fog", "Extinction Scale"), Tooltip("Scales the height fog particle extinction amount used by volumetric fog. Values larger than 1 cause fog particles everywhere absorb more light.")]
        public float VolumetricFogExtinctionScale
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetVolumetricFogExtinctionScale(unmanagedPtr); }
            set { Internal_SetVolumetricFogExtinctionScale(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the distance over which volumetric fog should be computed.
        /// </summary>
        /// <remarks>
        /// Larger values extend the effect into the distance but expose under-sampling artifacts in details.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(350), DefaultValue(6000.0f), Limit(0), EditorDisplay("Volumetric Fog", "Distance"), Tooltip("Distance over which volumetric fog should be computed. Larger values extend the effect into the distance but expose under-sampling artifacts in details.")]
        public float VolumetricFogDistance
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetVolumetricFogDistance(unmanagedPtr); }
            set { Internal_SetVolumetricFogDistance(unmanagedPtr, value); }
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetFogDensity(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetFogDensity(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetFogHeightFalloff(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetFogHeightFalloff(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetFogInscatteringColor(IntPtr obj, out Color resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetFogInscatteringColor(IntPtr obj, ref Color val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetFogMaxOpacity(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetFogMaxOpacity(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetStartDistance(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetStartDistance(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetFogCutoffDistance(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetFogCutoffDistance(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern DirectionalLight Internal_GetDirectionalInscatteringLight(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetDirectionalInscatteringLight(IntPtr obj, IntPtr val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetDirectionalInscatteringExponent(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetDirectionalInscatteringExponent(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetDirectionalInscatteringStartDistance(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetDirectionalInscatteringStartDistance(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetDirectionalInscatteringColor(IntPtr obj, out Color resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetDirectionalInscatteringColor(IntPtr obj, ref Color val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_GetVolumetricFogEnable(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetVolumetricFogEnable(IntPtr obj, bool val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetVolumetricFogScatteringDistribution(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetVolumetricFogScatteringDistribution(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetVolumetricFogAlbedo(IntPtr obj, out Color resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetVolumetricFogAlbedo(IntPtr obj, ref Color val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetVolumetricFogEmissive(IntPtr obj, out Color resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetVolumetricFogEmissive(IntPtr obj, ref Color val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetVolumetricFogExtinctionScale(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetVolumetricFogExtinctionScale(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetVolumetricFogDistance(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetVolumetricFogDistance(IntPtr obj, float val);
#endif

        #endregion
    }
}
