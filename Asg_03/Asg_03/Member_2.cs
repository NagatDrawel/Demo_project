using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    partial class Lab_7
    {
        static void Method_2()
        {
            Console.WriteLine("Please enter a sentence");
            String input = Console.ReadLine();
            var words = input.ToLower().Split().Distinct().OrderBy(x => x);

            Console.WriteLine("Unique Characters: ");
            foreach(var word in words)
            {
                Console.WriteLine(String.Concat(word));
            }
        }
    }
}
