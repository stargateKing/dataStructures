using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructures
{
    public interface ITreeItem<T>
    {
        /// <summary>
        /// The getter and setter for the item of specified type.
        /// </summary>
        T Item { get; set; }

        /// <summary>
        /// A getter for the children.
        /// </summary>
        IEnumerable<ITreeItem<T>> Children { get; }
    }
}
