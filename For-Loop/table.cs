using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
           int n,i;
           System.Console.Write("Enter the Number:");
           n = System.Convert.ToInt16(System.Console.ReadLine());
         
           for(i = 1 ; i <= 10 ; i++ )
           {
             System.Console.Write("\n"+n+" x "+i+" = "+n*i);
           }
        
         }
    }
}