using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("BEFORE Loops");
            Console.ReadKey();
            int count = 1;
            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.WriteLine(i);
               
            }
        }
    }
}
