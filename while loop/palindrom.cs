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
       System.Console.Write("Enter the Number:");
       n = System.Convert.ToInt16(System.Console.ReadLine());
       int temp = n;
       int rev = 0;
       while(temp != 0)
       {
           int rem = temp % 10;
           rev = rev * 10 + rem;
           temp = temp / 10;
       }
       if(n == rev)
       {
           System.Console.Write("The Number is Palindrom");
       }
       else
       {
           System.Console.Write("The Number is Not Palindrom");
       }
        
        }
    }
}
