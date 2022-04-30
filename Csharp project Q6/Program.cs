using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_project_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please insert your age: ");
            string x = Console.ReadLine();
            int age = Int32.Parse(x) + 10;
            Console.WriteLine("your age after 10 years is: " + age);
        }
    }
}
