using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is to hopefully skip the first line, just hit enter.");
            Console.ReadLine();
            char[] delimiterChars = { ' ' };
            string list = Console.ReadLine();
            string[] toSum = list.Split(delimiterChars);

            int sum = 0;


            for (Int32 i = 0; i < toSum.Length; i++)
            {
                
                sum += int.Parse(toSum[i]);
                
            }
            Console.WriteLine(sum);
            


            Console.ReadLine();
         

         }
        
    }
}
