using UnityEngine;
using System.Collections.Generic;

namespace DEnt
{
    /// <summary>
    /// An object tree explorer to aid in discovering descendent/ancestor objects.
    /// </summary>
    public static class ObjectTree
    {
        
        /* --------------------------------------------------------------------- */

        #region Class Members

        #endregion

        /* --------------------------------------------------------------------- */

        #region Properties

        #endregion

        /* --------------------------------------------------------------------- */

        #region Construction

        #endregion
            
        /* --------------------------------------------------------------------- */

        #region Public Methods

        /// <summary>
        /// Determines if a transform object is within the provided array of transform objects.
        /// </summary>
        /// <param name="transform">The transform object to test.</param>
        /// <param name="transforms">The transform object array to check.</param>
        /// <returns>True if the object is in the array, false otherwise.</returns>
        public static bool IsInArray( Transform transform, Transform[] transforms )
        {
            if ( transform == null || transforms == null || transforms.Length == 0 )
            {
                return false;
            }

            for ( int i = 0 ; i < transforms.Length ; i++ )
            {
                if ( transforms[ i ] == transform )
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Gets an array of the descendents for the specified transform object.
        /// </summary>
        /// <param name="transform">The transform object to find the descendents for.</param>
        /// <returns>An array of descendent transform objects, including the current transform object.</returns>
        public static Transform[] GetDescendentsAndSelf( Transform transform )
        {
            return FindDescendents( transform ).ToArray();
        }

        #endregion

        /* --------------------------------------------------------------------- */

        #region Private Methods

        /// <summary>
        /// Finds all the descendents for the specified transform object.
        /// </summary>
        /// <param name="transform">The transform object to find the descendents for.</param>
        /// <returns>An array of descendent transform objects, including the current transform object.</returns>
        private static List<Transform> FindDescendents( Transform transform )
        {
            List<Transform> descendents = new List<Transform>();

            if ( transform == null )
            {
                return descendents;
            }

            descendents.Add( transform );

            for ( int i = 0 ; i < transform.childCount ; i++ )
            {
                descendents.AddRange( FindDescendents( transform.GetChild( i ) ) );
            }

            return descendents;
        }

        #endregion

        /* --------------------------------------------------------------------- */

    }
}
