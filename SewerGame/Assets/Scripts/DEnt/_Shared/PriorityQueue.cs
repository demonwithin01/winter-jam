using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEnt
{
    /// <summary>
    /// A prioty queue of type V that is sorted by values of type P.
    /// </summary>
    /// <typeparam name="P">The value type that the queue will be sorted by</typeparam>
    /// <typeparam name="V">The object type that will be stored</typeparam>
    public class PriorityQueue<P, V> where V : class
    {

        /* ---------------------------------------------------------------------------------------------------------- */

        #region Class Members

        /// <summary>
        /// Holds the dictionary that will be used to maintain queue.
        /// </summary>
        private SortedDictionary<P, Queue<V>> list = new SortedDictionary<P, Queue<V>>();

        #endregion

        /* ---------------------------------------------------------------------------------------------------------- */

        #region Constructors/Initialisation

        #endregion

        /* ---------------------------------------------------------------------------------------------------------- */

        #region Public Methods

        /// <summary>
        /// Adds a new item to the priority queue.
        /// </summary>
        /// <param name="priority">The priority of this object.</param>
        /// <param name="value">The object to be added to the queue.</param>
        public void Enqueue( P priority, V value )
        {
            Queue<V> q;
            if ( !list.TryGetValue( priority, out q ) )
            {
                q = new Queue<V>();
                list.Add( priority, q );
            }
            q.Enqueue( value );
        }

        /// <summary>
        /// Removes and returns the first item in the queue.
        /// </summary>
        /// <returns>The first item in the queue, if any.</returns>
        public V Dequeue()
        {
            if ( list.Count == 0 )
            {
                return null;
            }
            
            KeyValuePair<P, Queue<V>> pair = list.First();
            V value = pair.Value.Dequeue();

            if ( pair.Value.Count == 0 ) // nothing left of the top priority.
            {
                list.Remove( pair.Key );
            }

            return value;
        }

        /// <summary>
        /// Returns whether or not there are no items left in the queue.
        /// </summary>
        public bool IsEmpty
        {
            get { return !list.Any(); }
        }

        /// <summary>
        /// Returns the total number of items in the queue.
        /// </summary>
        public int Length
        {
            get { return list.Count; }
        }

        #endregion

        /* ---------------------------------------------------------------------------------------------------------- */

        #region Private Methods

        #endregion

        /* ---------------------------------------------------------------------------------------------------------- */

        #region Properties

        #endregion

        /* ---------------------------------------------------------------------------------------------------------- */

    }
}
