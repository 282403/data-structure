using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kuaipai
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 20,19, 88, 66, 77,11 };
            Program pro = new Program();
            //pro.kuaipai(array, 0, array.Length - 1);
            pro.kuaisupaixu(array, 0, array.Length - 1);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.ReadKey();
        }

        //2 6 7 3 8 9
        //  3 7 6 8 9
        //2 3  6 7 8 9 

        public void kuaipai(int[] array, int left, int right)
        {
            if (left<right)
            {
                int i = left;
                int j = right;
                int k = array[left];

                while (i<j)
                {
                    while (i < j)
                    {
                        if (k >=array[j])
                        {
                            array[i] = array[j];
                            break;
                        }
                        else
                        {
                            j--;
                        }
                    }
                    array[j] = k;

                    while (i < j)
                    {
                        if (k <= array[i])
                        {
                            array[j] = array[i];
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }

                array[i] = k;
                kuaipai(array, ++i, right);
                kuaipai(array, left, --i);
            }
        }

        public void Maopao(int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i]>array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                        
                    }
                   
                }
            }
        }

        public void kuaisupaixu(int[] array, int left, int right)
        {
            if (left<right)
            {
                int i = left;
                int j = right;
                int k = array[left];

                while (i<j)
                {
                    while (i < j)
                    {
                        if (k > array[j])
                        {
                            array[i] = array[j];
                            break;
                        }
                        else
                        {
                            j--;
                        }
                    }
                    array[j] = k;
                    while (i < j)
                    {
                        if (k < array[i])
                        {
                            array[j] = array[i];
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    array[i] = k;
                    kuaisupaixu(array, left, i - 1);
                    kuaisupaixu(array, i + 1, right);
                }
                
            }
        }


        public void kuaisupaixu2(int[] array, int left, int right)
        {
            if (left<right)
            {
                int i = left;
                int j = right;
                int k = array[left];

                while (i<j)
                {
                    while (i<j)
                    {
                        if (k>array[j])
                        {
                            array[i] = array[j];
                            break;
                        }
                        else
                        {
                            j--;
                        }
                    }
                    while (i<j)
                    {
                        if (k<array[i])
                        {
                            array[j] = array[i];
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                array[i] = k;
                kuaisupaixu2(array, left, i - 1);
                kuaisupaixu2(array, i + 1, right);
            }
        }
    }
}
