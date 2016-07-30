using UnityEngine;

namespace DEnt
{
    /// <summary>
    /// Provides useful extensions for creating new Unity Color objects.
    /// </summary>
    public static class Colour
    {
        /// <summary>
        /// Creates a new Color object based off the provided RGB values.
        /// </summary>
        /// <param name="r">The red channel value.</param>
        /// <param name="g">The green channel value.</param>
        /// <param name="b">The blue channel value.</param>
        /// <returns>A new Unity Color object.</returns>
        public static Color RGB( int r, int g, int b )
        {
            return RGBA( r, g, b, 1 );
        }

        /// <summary>
        /// Creates a new Color object based off the provided RGBA values.
        /// </summary>
        /// <param name="r">The red channel value.</param>
        /// <param name="g">The green channel value.</param>
        /// <param name="b">The blue channel value.</param>
        /// <param name="a">The alpha channel value.</param>
        /// <returns>A new Unity Color object.</returns>
        public static Color RGBA( int r, int g, int b, float a )
        {
            float divisor = 255f;

            return new Color( r / divisor, g / divisor, b / divisor, a );
        }
    }
}