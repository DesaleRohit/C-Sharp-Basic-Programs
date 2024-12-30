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
            int n;
            System.Console.Write("Enter the Number between 1-7:");
            n = System.Convert.ToInt16(System.Console.ReadLine());
            
            switch(n)
            {
                case 1:
                System.Console.Write("Sunday");
                break;
                
                case 2:
                System.Console.Write("Monday");
                break;
                
                case 3:
                System.Console.Write("Tuesday");
                break;
                
                case 4:
                System.Console.Write("Wednesday");
                break;
                
                case 5:
                System.Console.Write("Thusday");
                break;
                
                case 6:
                System.Console.Write("Friday");
                break;
                
                case 7:
                System.Console.Write("Saturday");
                break;
                
                default:
                System.Console.Write("Invalid Number");
            }
        }
   }

}