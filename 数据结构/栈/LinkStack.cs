using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 栈
{
    class LinkStack<T>:IStackDS<T>
    {
        private Node<T> top;//栈顶元素节点
        private int count = 0;//栈中元素的个数


        /// <summary>
        /// 取得栈中元素个数
        /// </summary>
        public int Count
        {
            get { return count; }

        }

        /// <summary>
        /// 取得栈中元素个数
        /// </summary>
        public int GetLength()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        /// <summary>
        ///  清空栈中的所有数据
        /// </summary>
        public void Clear()
        {
            count = 0;
            top = null;
        }
        /// <summary>
        /// 入栈
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            //把新添加的元素作为栈顶作为头节点（栈顶）
            Node<T> newNode = new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            count++;    

        }
        //出栈 取得栈顶元素，然后删除
        public T pop()
        {
            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }
        /// <summary>
        /// 取得栈顶中的数据，不删除栈顶
        /// </summary>
        /// <returns></returns>
        public T peek()
        {
            return top.Data;
        }
    }
}
