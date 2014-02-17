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


         var numbers = Console.ReadLine();

         String list = Console.ReadLine();
            int[] toSum = new int[] {int.Parse(list)};
            int sum = 0;
          
            
          for (Int32 i = 0; i <= toSum.Length; i++)
            {
             sum += toSum[i];
            }
             
         Console.WriteLine(sum);
         Console.ReadLine();
         }
        
    }
}
