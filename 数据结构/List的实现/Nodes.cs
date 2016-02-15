using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List的实现
{
    /// <summary>
    /// 单链表的节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Nodes<T>
    {
        private T data;//存储数据
        private Nodes<T> next;//指针 用来纸箱下一个元素


        public Nodes()
        {
            data = default(T);
        }


        public Nodes(T value)
        {
            data = value;
            next = null;
        }
        public Nodes(T value, Nodes<T> next)
        {
            this.data = value;
            this.next = next;
        }
        public Nodes(Nodes<T> next)
        {
            this.next = next;
        }
        public T Data
        {
            get { return data; } 
            set { data = value; }
        }

        public Nodes<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
