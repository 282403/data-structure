using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 栈
{
    interface IStackDS<T>
    {
        int Count { get; }
        int GetLength();
        bool IsEmpty();
        void Clear();
        void Push(T item);
        T pop();
        T peek();
    }
}
