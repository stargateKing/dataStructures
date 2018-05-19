using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructures
{
    public class BinaryTree<T>
    {
        public BinaryTree()
        {
            this.Root = null;
        }

        public ITreeItem<T> Root { get; private set; }
    }
}
