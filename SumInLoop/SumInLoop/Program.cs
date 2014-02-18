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
         //string numbers = Console.ReadLine();
        //string list = Console.ReadLine();
        //int[] toSum = new int[] { int.Parse(list) };

         int[] toSum = new int[] { 10, 20, 30, 40, 5, 6, 7, 8 };
            int sum = 0;
          
            
          for (Int32 i = 0; i <= toSum.Length; i++)
            {
                Console.WriteLine(sum += toSum[i]);
            }

         
         Console.ReadLine();
         
         }
        
    }
}
