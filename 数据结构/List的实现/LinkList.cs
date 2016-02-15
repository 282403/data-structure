using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List的实现
{
    class LinkList<T>:IListDS<T>
    {
        private Nodes<T> head;

        public LinkList()
        {
            head = null;
        }

        public int GetLength()
        {
            if (head==null)
            {
                return 0;
            }
            Nodes<T> temp = head;
            int count = 1;
            while(true)
            {
                if (temp.Next != null)
                {
                    count++;
                    temp = temp.Next;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        public void Clear()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            //if (head==null)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
            return head == null;
        }

        public void Add(T item)
        {
            Nodes<T> newNode = new Nodes<T>(item);
            if (head==null)
            {
                head = newNode;

            }
            else
            {
                Nodes<T> temp = head;
                while (true)
                {
                    if (temp.Next!=null)
                    {
                        temp = temp.Next;
                    }
                    else
                    {
                        break;
                    }
                }
                temp.Next = newNode;
            }
        }

        public void Insert(T item, int index)
        {
            Nodes<T> newNode = new Nodes<T>(item);
            if (index==0)
            {
                newNode.Next = head;
                head = newNode;
                
            }
            else
            {
                Nodes<T> temp = head;
                for (int i = 1; i < index; i++)
                {
                    temp = temp.Next;
                }
                Nodes<T> before_Node = temp;
                Nodes<T> After_Node = temp.Next;
                before_Node.Next = newNode;
                newNode.Next = After_Node;
            }
        }

        public T Delete(int index)
        {
            T data = default(T);

            if (index==0)
            {
                data = head.Data;
                head = head.Next;    
            }
            else
            {
                Nodes<T> temp = head;
                for (int i = 1; i < index; i++)
                {
                    temp = temp.Next;
                }
                Nodes<T> before_Node = temp;
                Nodes<T> currentNode = temp.Next;
                data = currentNode.Data;
                Nodes<T> after_Node = temp.Next.Next;
                before_Node.Next = after_Node;
                
            }
            return data;
          
          

            
        }

        public T GetEle(int index)
        {
            Nodes<T> temp = head;
            for (int i = 1; i < index; i++)
            {
                temp = temp.Next;
            }
            return temp.Data;
        }

        public T this[int index]
        {
            get {return GetEle(index); }
        }

        public int Locate(T value)
        {
            Nodes<T> temp = head;
            int count = 0;
            if (temp == null)
            {
                    return -1;
            }
            else
            {
                while (true)
                {
                    count++;
                    if (temp.Data.Equals(value))
                    {
                        return count;
                    }
                    else
                    {
                        if (temp.Next != null)
                        {
                            temp = temp.Next;
                        }
                        else
                        {
                            break;
                        }
                    }       
                }
                return -1;
            }
            
            
        }
    }
}
