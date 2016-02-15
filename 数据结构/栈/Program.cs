using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 栈
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //1.使用BCL中的Stack<T>
            IStackDS<Char> STACK = new LinkStack<char>();
            STACK.Push('a');
            STACK.Push('b');
            STACK.Push('c');
            Console.WriteLine(STACK.Count);
            char temp =   STACK.pop();//取得栈顶数据，并把该数据删除
            Console.WriteLine(temp);
            Console.WriteLine(STACK.Count);
            char temp2 = STACK.peek();
            Console.WriteLine(temp2);

            Console.ReadKey();

        }
    }
}
