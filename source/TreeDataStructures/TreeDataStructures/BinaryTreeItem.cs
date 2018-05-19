using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructures
{
    public class BinaryTreeItem<T> : ITreeItem<T>
    {
        private ITreeItem<T>[] _children;

        public BinaryTreeItem(T value)
        {
            this.Item = value;
            this._children = new ITreeItem<T>[2];
        }

        public T Item { get; set; }

        public IEnumerable<ITreeItem<T>> Children => this._children;

        public ITreeItem<T> LeftChild {
            get
            {
                return this._children[0];
            }
            set
            {
                this._children[0] = value;
            }
        }

        public ITreeItem<T> RightChild
        {
            get
            {
                return this._children[1];
            }
            set
            {
                this._children[1] = value;
            }
        }
    }
}
