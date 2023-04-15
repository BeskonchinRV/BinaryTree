using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Add(18);
            tree.Add(15);
            tree.Add(5);
            tree.Add(21);
            tree.Add(60);

            Node found = tree.Search(1);
            if (found != null)
            {
                Console.WriteLine("Найдено: " + found.Data);
            }
            else
            {
                Console.WriteLine("Не найдено");
            }
        }
    }
}
