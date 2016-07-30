using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace DEnt
{
    /// <summary>
    /// A point in a 2D grid.
    /// </summary>
    public struct Point2D
    {

        /* ---------------------------------------------------------------------------------------------------------- */

        #region Class Members

        #endregion

        /* ---------------------------------------------------------------------------------------------------------- */

        #region Constructors/Initialisation
            
        /// <summary>
        /// Creates a new point using the co-ordinates provided.
        /// </summary>
        /// <param name="x">The x position of the point.</param>
        /// <param name="y">The y position of the point.</param>
        public Point2D( int x, int y )
        {
            X = x;
            Y = y;
        }

        #endregion

        /* ---------------------------------------------------------------------------------------------------------- */

        #region Public Methods

        /// <summary>
        /// Creates a new instance of this point as a Vector2 object.
        /// </summary>
        public Vector2 ToVector2()
        {
            return new Vector2( X, Y );
        }

        /// <summary>
        /// Creates a new instance of this point as a Vector3 object.
        /// </summary>
        public Vector3 ToVector3()
        {
            return new Vector3( X, Y );
        }

        #endregion

        /* ---------------------------------------------------------------------------------------------------------- */

        #region Private Methods

        #endregion

        /* ---------------------------------------------------------------------------------------------------------- */

        #region Properties

        /// <summary>
        /// Gets/Sets the X position of the point.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets/Sets the Y position of the point.
        /// </summary>
        public int Y { get; set; }

        #endregion

        /* ---------------------------------------------------------------------------------------------------------- */

    }
}
