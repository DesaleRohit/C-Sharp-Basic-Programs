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
           int n;
           System.Console.Write("Enter the Number:");
           n = System.Convert.ToInt16(System.Console.ReadLine());
           if(n%2==0)
           {
               System.Console.Write("The Number is Even");
           }
           else
           {
               System.Console.Write("The Number is odd");
           }
        }
    }
}
