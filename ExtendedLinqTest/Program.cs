using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtendedLinq;

namespace ExtendedLinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "Dog,Cat,Rabbit,Dog,Dog,Lizard,Cat,Cat,Dog,Rabbit,Guinea Pig,Dog";
            var output = input.Split(',').CountBy(x => x);

            foreach (var it in output)
            {
                Console.WriteLine("{0} : {1}", it.Key, it.Value);
            }
            
            Console.ReadKey(true);
        }
    }
}
