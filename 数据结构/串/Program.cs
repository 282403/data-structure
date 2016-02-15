using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 串
{
    class Program
    {
        static void Main(string[] args)
        {



            //StringDS sDS = new StringDS("sccacaca");
            //StringDS DSs = new StringDS("acaca");
            //int i =  sDS.IndexOf(DSs);

            //String test = "sccacaca";
            //String test2 = "acaca";
            Program p = new Program();
            p.exercises();
            Console.ReadKey();
            //int c = test.IndexOf(test2);
            //   Console.WriteLine(i);
            //   Console.WriteLine(c);
            //   Console.ReadKey();
            

            
           
        }
        public void exercises()
        {
            StringDS s = new StringDS("i am cccc");
            StringDS c = new StringDS("am cc");
            StringDS r = new StringDS(" bbb");
            int di = 0;
            while (true)
            {
                di++;
               int i = s.IndexOf(c);
               Console.WriteLine(s[i]);
               s[i] = r[2];
               Console.WriteLine(s[i]);
               if (di==s.GetLength())
               {
                   break;
               }
              
            }

        }
    }
}
