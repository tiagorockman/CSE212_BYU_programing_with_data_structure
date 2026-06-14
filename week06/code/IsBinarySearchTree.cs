using System;
using System.Collections.Generic;
using System.Text;

namespace code
{
    public static class IsBinarySearchTree
    {
        public static bool IsBST(TestNode node, int? min = null, int? max = null)
        {
            if (node == null)
                return true;

            if ((min != null && node.Data <= min) ||
                (max != null && node.Data >= max))
                return false;

            return IsBST(node.Left, min, node.Data) &&
                   IsBST(node.Right, node.Data, max);
        }
        // The above method checks if the current node's data is within the valid range defined by min and max.
        // It then recursively checks the left subtree, updating the max to the current node's data,
        // and the right subtree, updating the min to the current node's data.
        // This ensures that all nodes in the left subtree are less than the current node's data,
        // and all nodes in the right subtree are greater than the current node's data.
    }
}
