using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    internal class BinaryTree
    {

        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        // Insert a node
        public void Insert(int value)
        {
            Root = InsertRecursive(Root, value);
        }

        private Node InsertRecursive(Node root, int value)
        {
            if (root == null)
            {
                return new Node(value);
            }

            if (value < root.Value)
            {
                root.Left = InsertRecursive(root.Left, value);
            }
            else if (value > root.Value)
            {
                root.Right = InsertRecursive(root.Right, value);
            }

            return root;
        }

        // Delete a node
        public void Delete(int value)
        {
            Root = DeleteRecursive(Root, value);
        }

        private Node DeleteRecursive(Node root, int value)
        {
            if (root == null)
                return root;

            if (value < root.Value)
            {
                root.Left = DeleteRecursive(root.Left, value);
            }
            else if (value > root.Value)
            {
                root.Right = DeleteRecursive(root.Right, value);
            }
            else
            {
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }

                root.Value = FindMin(root.Right).Value;
                root.Right = DeleteRecursive(root.Right, root.Value);
            }

            return root;
        }

        private Node FindMin(Node root)
        {
            while (root.Left != null)
            {
                root = root.Left;
            }
            return root;
        }

        // Search for a value
        public Node Search(int value)
        {
            return SearchRecursive(Root, value);
        }

        private Node SearchRecursive(Node root, int value)
        {
            if (root == null || root.Value == value)
            {
                return root;
            }

            if (value < root.Value)
            {
                return SearchRecursive(root.Left, value);
            }
            return SearchRecursive(root.Right, value);
        }

        // Count the nodes in the subtree
        public int CountNodes(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + CountNodes(root.Left) + CountNodes(root.Right);
        }

        // Get tree information for DataGridView
        public List<string[]> GetTreeRows()
        {
            List<string[]> rows = new List<string[]>();
            PopulateRows(Root, rows);
            return rows;
        }

        private void PopulateRows(Node node, List<string[]> rows)
        {
            if (node == null)
                return;

            string root = node.Value.ToString();
            string left = node.Left != null ? node.Left.Value.ToString() : "None";
            string right = node.Right != null ? node.Right.Value.ToString() : "None";
            int nodesInBranch = CountNodes(node) - 1; // Exclude the root node itself
            string children = GetChildren(node);

            rows.Add(new string[] { root, left, right, nodesInBranch.ToString(), children });

            PopulateRows(node.Left, rows);
            PopulateRows(node.Right, rows);
        }

        private string GetChildren(Node node)
        {
            var children = new List<string>();
            if (node.Left != null) children.Add(node.Left.Value.ToString());
            if (node.Right != null) children.Add(node.Right.Value.ToString());
            return children.Count > 0 ? string.Join(", ", children) : "None";
        }
    }

    

}

