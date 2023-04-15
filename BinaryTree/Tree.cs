using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Tree
    {
        public Node Root;

        public Tree()
        {
            Root = null;
        }

        public void Add(int data)
        {
            if (Root == null)
            {
                Root = new Node(data);
                return;
            }

            Node current = Root;
            while (true)
            {
                if (data < current.Data)
                {
                    if (current.Left == null)
                    {
                        current.Left = new Node(data);
                        break;
                    }
                    current = current.Left;
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = new Node(data);
                        break;
                    }
                    current = current.Right;
                }
            }
        }

        public Node Search(int data)
        {
            Node current = Root;
            while (current != null)
            {
                if (data == current.Data)
                {
                    return current;
                }
                else if (data < current.Data)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            return null;
        }
    }
}
