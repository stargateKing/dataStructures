using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeDataStructures;

namespace TreeDataStructuresTests
{
    [TestClass]
    public class BinaryTreeUnitTests
    {
        [TestMethod]
        public void CreateBinaryTree()
        {
            var newBinaryTree = new BinaryTree<int>();
            Assert.AreEqual(null, newBinaryTree.Root);
        }
    }
}
