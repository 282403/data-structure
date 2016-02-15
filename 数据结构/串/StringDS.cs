using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 串
{
    class StringDS
    {
        private char[] data;
        public StringDS(char[] array)
        {
            data = new char[array.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = array[i];
            }
        }
        public StringDS(string str)
        {
            data = new char[str.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = str[i];
                
                
            }
           
        }
       
        public char this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        
        }
        public int GetLength()
        {
            return data.Length;
        }
        /// <summary>
        /// 如果两个字符串一样 返回0
        /// 如果当前字符串小于S，那么返回-1
        /// 如果当前字符串大于s，那么返回1
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Compare(StringDS s)
        {
            int len = this.GetLength() < s.GetLength() ? this.GetLength() : s.GetLength();//取得两个字符串中的长度更小的字符串长度：
            int index = -1;//存储不想等的字符的索引位置
            for (int i = 0; i < len; i++)
            {
                if (this[i]!=s[i])
                {
                    index = i;
                    break;
                }
            }
            if (index!=-1)
            {
                if (this[index]>s[index])
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (this.GetLength()==s.GetLength())
                {
                    return 0;
                }
                else
                {
                    if (this.GetLength()>s.GetLength())
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        public StringDS SubString(int index,int length)
        {
            char[] newData = new char[length];
            for (int i = index; i < index+length; i++)
            {
                newData[i - index] = data[i];

            }
            return new StringDS(newData);
        }

        public static StringDS Concat(StringDS s1, StringDS s2)
        {
            char[] newData = new char[s1.GetLength()+s2.GetLength()];
            for (int i = 0; i < s1.GetLength(); i++)
            {
                newData[i] = s1[i];
            }
            for (int i = s1.GetLength(); i < newData.Length; i++)
            {
                newData[i] = s2[i - s1.GetLength()];
            }
            return new StringDS(newData);
        }

        public int IndexOf(StringDS s)
        {
            for (int i = 0; i <= this.GetLength()-s.GetLength(); i++)
            {
                bool IsEqual = true;
                for (int j = i; j < i+s.GetLength(); j++)
                {
                    if (this[j]!=s[j-i])
                    {
                        IsEqual = false;
                        break; 
                    }
                }
                if (IsEqual)
                {
                    return i;
                }
                else
                {
                    continue;
                }
            }
            return -1;
        }
       
    }
}
