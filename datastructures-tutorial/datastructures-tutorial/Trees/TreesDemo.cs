namespace datastructures_tutorial.Trees
{
    public class TreesDemo
    {
        public static void Run()
        {
            // Create a Binary Search Tree
            BinarySearchTree bst = new BinarySearchTree();

            // Insert nodes into the tree
            bst.Insert(59);
            bst.Insert(87);
            bst.Insert(25);
            bst.Insert(22);
            bst.Insert(40);
            bst.Insert(9);
            bst.Insert(2);

            // Display the original tree structure
            Console.WriteLine("Original Tree:");
            bst.Order();

            // Check if a value is in the tree
            int valueToCheck = 9;
            Console.WriteLine($"Does {valueToCheck} appear in the tree? {bst.Contains(valueToCheck)}");

            // Remove a node from the tree
            int valueToRemove = 22;
            Console.WriteLine($"Removing {valueToRemove}...");
            bst.Remove(valueToRemove);

            // Display the tree after removal
            Console.WriteLine("Tree after removal:");
            bst.Order();
        }
    }

    // Define a tree node
    public class TreeNode
    {
        public int Value;
        public TreeNode? Left;
        public TreeNode? Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = Right = null;
        }
    }

    // Define a binary search tree class
    public class BinarySearchTree
    {
        private TreeNode? root;

        public BinarySearchTree()
        {
            root = null;
        }

        // Public method to insert a value
        public void Insert(int value)
        {
            root = InsertRecursive(root, value);
        }
        
        // Recursive helper method for insertion
        private TreeNode InsertRecursive(TreeNode current, int value)
        {
            if (current == null)
            {
                // If the current node is null, create a new node with the given value
                return new TreeNode(value);
            }

            // Decide whether to go left or right based on the comparison with the current node's value
            if (value < current.Value)
            {
                current.Left = InsertRecursive(current.Left, value);
            }
            else if (value > current.Value)
            {
                current.Right = InsertRecursive(current.Right, value);
            }

            // Return the current node
            return current;
        }

        // Check if a value is present in the tree
        public bool Contains(int value)
        {
            return ContainsRecursive(root, value);
        }

        // Recursive helper method for checking containment
        private bool ContainsRecursive(TreeNode current, int value)
        {
            if (current == null)
            {
                // If the current node is null, the value is not in the tree
                return false;
            }

            // Check if the value is equal to the current node's value
            if (value == current.Value)
            {
                return true;
            }
            else if (value < current.Value)
            {
                // Recursively check the left subtree
                return ContainsRecursive(current.Left, value);
            }
            else
            {
                // Recursively check the right subtree
                return ContainsRecursive(current.Right, value);
            }
        }

        // Remove a value from the tree
        public void Remove(int value)
        {
            root = RemoveRecursive(root, value);
        }

        // Recursive helper method for removal
        private TreeNode RemoveRecursive(TreeNode current, int value)
        {
            if (current == null)
            {
                // If the current node is null, nothing to remove
                return null;
            }

            // Check if the value is equal to the current node's value
            if (value == current.Value)
            {
                if (current.Left == null)
                {
                    // If there is no left child, return the right child
                    return current.Right;
                }
                else if (current.Right == null)
                {
                    // If there is no right child, return the left child
                    return current.Left;
                }

                // Replace the current node's value with the minimum value from the right subtree
                current.Value = MinValue(current.Right);
                // Remove the node with the minimum value from the right subtree
                current.Right = RemoveRecursive(current.Right, current.Value);
            }
            else if (value < current.Value)
            {
                // Recursively remove from the left subtree
                current.Left = RemoveRecursive(current.Left, value);
            }
            else
            {
                // Recursively remove from the right subtree
                current.Right = RemoveRecursive(current.Right, value);
            }

            // Return the current node
            return current;
        }

        // Find the minimum value in a subtree
        private int MinValue(TreeNode node)
        {
            int minValue = node.Value;
            while (node.Left != null)
            {
                // Traverse to the leftmost node to find the minimum value
                minValue = node.Left.Value;
                node = node.Left;
            }
            return minValue;
        }

        // Organize and Display the tree
        public void Order()
        {
            OrderRecursive(root);
            Console.WriteLine();
        }

        // Recursive helper method for Order
        private void OrderRecursive(TreeNode current)
        {
            if (current != null)
            {
                // Traverse left, visit current node, traverse right
                OrderRecursive(current.Left);
                Console.Write(current.Value + " ");
                OrderRecursive(current.Right);
            }
        }
    }
}
