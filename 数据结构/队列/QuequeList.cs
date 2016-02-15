using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 队列
{
    class QuequeList<T>:IQueue<T>
    {

        private T[] data;
        private int count;//表示当前有多少个元素
        private int front;//队首(队首元素索引-1)
        private int rear;//队尾（=队尾元素索引）

        public QuequeList(int size)
        {
            data = new T[size];
            count = 0;
            front = -1;
            rear = -1;
        }
        public QuequeList(): this(10)
        {

        }

        public int Count
        {
            get { return count; }
        }

        public int GetLength()
        {
            return count;
        }

        public bool IsEmpty()
        {
           return count == 0;
        }

        public void Clear()
        {
            count = 0;
            front = -1;
            rear = -1;
        }

        public void Enqueue(T item)
        {
            if (count ==data.Length)
            {
                Console.WriteLine("数组已满");
            }
            else
            {
                if (rear==data.Length-1)
                {
                    data[0] = item;
                    rear = 0;
                    count++;
                }
                else
                {
                    data[rear + 1] = item;
                    rear++;
                    count++;
                    
                }
            }
           
           
        }

        public T Dequque()
        {
            if (count > 0)
            {
                T temp = data[front + 1];
                front++;
                count--;
                return temp;
            }
            else
            {
                Console.WriteLine("队列为空");
                return default(T);
            }
        }

        public T Peek()
        {
            T temp = data[front + 1];
            return temp;
        }
    }
}
