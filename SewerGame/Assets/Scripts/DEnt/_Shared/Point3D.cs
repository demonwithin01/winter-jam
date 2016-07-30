using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace DEnt
{
    /// <summary>
    /// A point in a 3D grid.
    /// </summary>
    public struct Point3D
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
        /// <param name="z">The z position of the point.</param>
        public Point3D( int x, int y, int z )
        {
            X = x;
            Y = y;
            Z = z;
        }

        #endregion

        /* ---------------------------------------------------------------------------------------------------------- */

        #region Public Methods

        /// <summary>
        /// Creates a new instance of this point as a Vector3 object.
        /// </summary>
        public Vector3 ToVector3()
        {
            return new Vector3( X, Y, Z );
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

        /// <summary>
        /// Gets/Sets the Z position of the point.
        /// </summary>
        public int Z { get; set; }

        #endregion

        /* ---------------------------------------------------------------------------------------------------------- */

    }
}
