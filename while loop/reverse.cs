using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,r;
            System.Console.Write("Enter the Number:");
            n = System.Convert.ToInt16(System.Console.ReadLine());
        
            System.Console.Write("\nRevers Number is:");
        
            while(n>0)
           {
               r = n % 10;
               System.Console.Write(r);
               n = n / 10;
           }
       
        }
    }
}
