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
           int n,sum=0;
           System.Console.Write("Enter the number:");
           n = System.Convert.ToInt16(System.Console.ReadLine());
        
           for(int i=1 ; i<=n ; i++)
          {
             sum += i;
          }
            System.Console.Write("Addition is "+sum);
          }
    }
}