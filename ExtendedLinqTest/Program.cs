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
            var output = input.Split(',').CountDuplicated();

            foreach (var it in output)
            {
                Console.WriteLine("{0} : {1}", it.Key, it.Value);
            }

            var input2 = new[]
            {
                new {Name = "Hoang", Age = 30}, new {Name = "Hien", Age = 30}, new {Name = "Khanh", Age = 25},
                new {Name = "Vinh", Age = 30}, new {Name = "Hao", Age = 24}
            };

            var output2 = input2.CountDuplicatedProperty(x => x.Age);
            foreach (var it in output2)
            {
                Console.WriteLine("{0} : {1}", it.Key, it.Value);
            }

            Console.ReadKey(true);
        }
    }
}
