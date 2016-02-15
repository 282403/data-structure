using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 队列
{
    interface IQueue<T>
    {
        int Count { get; }//取得队列的长度的属性
        int GetLength();//求队列的长度
        bool IsEmpty();//判断队列是否为空
        void Clear();//清空队列
        void Enqueue(T item);//入队
        T Dequque();//出队
        T Peek();//取队头元素
    }
}
