using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 队列
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<int> queue = new QuequeList<int>();
            queue.Enqueue(23);
            queue.Enqueue(45);
            queue.Enqueue(67);
            queue.Enqueue(89);
            Console.WriteLine("添加了23 45 67 89之后队列的大小为："+queue.Count);
            int i = queue.Dequque();
            Console.WriteLine("队首的数据" + i);
            Console.WriteLine("出队之后队列的大小为:" + queue.Count);
            int j = queue.Peek();
            Console.WriteLine("peek得到的结果：" + j);
            Console.WriteLine("Peek之后队列的大小为:" + queue.Count);
            queue.Clear();

            Console.WriteLine("clear 之后队列的大小为" + queue.Count);

            Console.ReadKey();

        }
    }
}
