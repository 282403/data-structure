using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List的实现
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList<string> seq = new LinkList<string>();



            //try
            //{

            //}
            //catch (FormatException)
            //{

            //    throw;
            //}
            seq.Add("11");
            seq.Add("22");
            seq.Add("33");
            seq.Add("44");
            seq.Add("55");
            seq.Insert("7", 3);
                Console.WriteLine(seq.GetEle(1));
                Console.WriteLine(seq.GetEle(2));
                Console.WriteLine(seq.GetEle(3));
                Console.WriteLine(seq.GetEle(4));
                Console.WriteLine(seq.GetEle(5));
                seq.Delete(3);
                Console.WriteLine(seq.GetEle(3));
                Console.WriteLine(seq.GetEle(4));
            


            Console.ReadKey();
        }
    }
}
