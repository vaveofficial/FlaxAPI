// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.

namespace FlaxEngine.GUI
{
    /// <summary>
    /// Implementation of <see cref="IBrush"/> for <see cref="FlaxEngine.MaterialBase"/> rendering.
    /// </summary>
    /// <seealso cref="IBrush" />
    public sealed class MaterialBrush : IBrush
    {
        /// <summary>
        /// The material.
        /// </summary>
        [ExpandGroups, Tooltip("The material to use for GUI control area rendering. It must be GUI domain.")]
        public MaterialBase Material;

        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialBrush"/> class.
        /// </summary>
        public MaterialBrush()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialBrush"/> struct.
        /// </summary>
        /// <param name="material">The material.</param>
        public MaterialBrush(Material material)
        {
            Material = material;
        }

        /// <inheritdoc />
        public Vector2 Size => Vector2.One;

        /// <inheritdoc />
        public void Draw(Rectangle rect, Color color, bool withAlpha = false)
        {
            Render2D.DrawMaterial(Material, rect, color);
        }
    }
}
