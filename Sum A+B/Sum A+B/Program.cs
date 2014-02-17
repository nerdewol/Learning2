using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Finds first variable
            Console.WriteLine("What is the first number you would  like to sum");
            string x = Console.ReadLine();
            //Finds second variable
            Console.WriteLine("What is the second number you would  like to sum");
            string y = Console.ReadLine();
            //Sums variables
            int answer = int.Parse(x) + int.Parse(y);
            //Displays answer        
            Console.WriteLine("Your answer is " + answer);
            Console.ReadLine();
                   


            
        }
    }
}
