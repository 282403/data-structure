using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List的实现
{
    interface IListDS<T>
    {
        int GetLength();
        void Clear();
        bool IsEmpty();
        void Add(T item);
        void Insert(T item, int index);
        T Delete(int index);
        T GetEle(int index);
        T this[int index] { get; }
       
        int Locate(T value);
    }
}
