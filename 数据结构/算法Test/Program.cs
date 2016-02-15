using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.Serialization;

namespace 算法Test
{
    class Program
    {
        static void Main(string[] args)
        {
            twotree<string> ss = new twotree<string>();
            
            Console.WriteLine(ss);
            Console.ReadKey();
           
        }
        public void test(out int i)
        {
            i = 44;
        }
    }
    public class twotree<T>
    {
        public T test<T>(Stream stream,IFormatter formater)
        {
            return (T)formater.Deserialize(stream);
        }
    }

   
    
}
