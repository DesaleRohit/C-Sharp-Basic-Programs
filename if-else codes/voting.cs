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
            System.Console.Write("Enter the age:");
            
            n = System.Convert.ToInt16(System.Console.ReadLine());
            
            if(n>=18)
            {
                System.Console.Write("Elegible for voting");
            }
            else
            {
                System.Console.Write("Not Elegible for voting");
            }
            System.Console.Read();

        }
    }
}
