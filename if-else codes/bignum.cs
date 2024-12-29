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
            int a,b,c;
            System.Console.Write("Enter the First Number:");
            a = System.Convert.ToInt16(System.Console.ReadLine());
            
             System.Console.Write("Enter the Second Number:");
            b = System.Convert.ToInt16(System.Console.ReadLine());
            
             System.Console.Write("Enter the Third Number:");
            c = System.Convert.ToInt16(System.Console.ReadLine());
            
            if(a > b)
            {
                if(a > c)
                {
                    System.Console.Write(a+" is the Biggest Number..");
                }
                else
                {
                    System.Console.Write(c+" is the Biggest Number..");
                }
            }
            else
            {
                if(b > c)
                {
                    System.Console.Write(b+" is the Biggest Number..");
                }
                else
                {
                    System.Console.Write(c+" is the Biggest Number...");
                }
            }

        }
    }
}