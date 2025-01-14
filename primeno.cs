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
            System.Console.WriteLine("Prime Number Program");
            int n , i, flag = 1;

            System.Console.WriteLine("Enter Any Number");
            n = Convert.ToInt16(System.Console.ReadLine());

            if (n == 1)
            {

                flag = 1;
            }
            else {

                for (i = 2; i < n; i++) {

                    if (n % i == 0) {

                        flag = 0;
                        break;

                    }
                }
                
            }
            if (flag == 1)
            {
                System.Console.WriteLine("The number is Prime...");
            }
            else 
            {
                System.Console.WriteLine("The  number is Not-prime...");
            }
            System.Console.ReadLine();

        }
    }
}