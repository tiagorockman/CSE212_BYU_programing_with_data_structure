using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace code
{
    [TestClass]
    public class IsBinarySearchTreeTest
    {

        [TestMethod]
        public void ValidBST_ShouldReturnTrue()
        {
            TestNode root = new TestNode(50);
            root.Left = new TestNode(30);
            root.Right = new TestNode(70);
            root.Left.Left = new TestNode(20);
            root.Left.Right = new TestNode(40);
            root.Right.Left = new TestNode(60);
            root.Right.Right = new TestNode(80);
            Assert.IsTrue(IsBinarySearchTree.IsBST(root));
            //Draw the tree:
             
            /*
                    50
                   /  \
                 30    70
                / \   / \
              20  40 60  80
            */

        }

        [TestMethod]
        public void InvalidBST_LeftChildGreaterThanParent_ShouldReturnFalse()
        {
            TestNode root = new TestNode(50);
            root.Left = new TestNode(60);   // Invalid
            root.Right = new TestNode(70);

            Assert.IsFalse(IsBinarySearchTree.IsBST(root));
            //Draw the tree:
            /*
                    50
                   /  \
                 60    70
            */
        }

        [TestMethod]
        public void InvalidBST_RightChildLessThanParent_ShouldReturnFalse()
        {
            TestNode root = new TestNode(50);
            root.Left = new TestNode(30);
            root.Right = new TestNode(40); // Invalid

            Assert.IsFalse(IsBinarySearchTree.IsBST(root));
            //Draw the tree:
            /*
                    50
                   /  \
                 30    40
            */
        }

        [TestMethod]
        public void InvalidBST_DeepNodeViolatesRule_ShouldReturnFalse()
        {
            TestNode root = new TestNode(50);
            root.Left = new TestNode(30);
            root.Right = new TestNode(70);

            root.Left.Left = new TestNode(20);
            root.Left.Right = new TestNode(60); // Invalid

            Assert.IsFalse(IsBinarySearchTree.IsBST(root));
            //Draw the tree:
            /*
                    50
                   /  \
                 30    70
                / \   
              20  60 
            */
        }

        [TestMethod]
        public void EmptyTree_ShouldReturnTrue()
        {
            Assert.IsTrue(IsBinarySearchTree.IsBST(null));
        }

        [TestMethod]
        public void SingleNodeTree_ShouldReturnTrue()
        {
            TestNode root = new TestNode(50);

            Assert.IsTrue(IsBinarySearchTree.IsBST(root));
        }
    }
}
