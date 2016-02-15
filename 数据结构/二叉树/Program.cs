using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace 二叉树
{
    class Program
    {
        static void Main(string[] args)
        {



            TwoTree tree = new TwoTree(10);
            tree.add(12);
            tree.add(9);
            tree.add(55);
            tree.add(1);
            tree.add(15);
            tree.add(5);
            tree.add(20);
            tree.add(35);
            tree.add(99);

            //Console.WriteLine(tree.ToString());
            // Console.WriteLine(tree.Delete(99));

            Console.WriteLine(tree.modify(99, 2));
            // Console.WriteLine(tree.modify(99, 2));
            Console.WriteLine(tree.Find(99));

            Console.ReadKey();

           

            
        }
    }
}
