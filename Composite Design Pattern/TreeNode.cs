using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Design_Pattern
{
    public class TreeNode<T> where T : IComparable<T>
    {

        // Add a child tree node
        public TreeNode<T> Add(T child)
        {
            var newNode = new TreeNode<T> { Node = child };
            Children.Add(newNode);
            return newNode;
        }

        // Remove a child tree node
        public void Remove(T child)
        {
            foreach (var treeNode in Children)
            {
                if (treeNode.Node.CompareTo(child) == 0)
                {
                    Children.Remove(treeNode);
                    return;
                }
            }
        }

        // Gets or sets the node
        public T Node { get; set; } = default!;

        // Gets treenode children
        public List<TreeNode<T>> Children { get; } = [];

        // Recursively displays node and its children 
        public static void Display(TreeNode<T> node, int indentation)
        {
            var line = new string('-', indentation);
            Console.WriteLine(line + " " + node.Node);

            node.Children.ForEach(n => Display(n, indentation + 1));
        }
    }
}
