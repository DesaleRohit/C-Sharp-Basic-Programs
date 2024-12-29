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

          int n1,n2,result=0;
          char op;
       
           System.Console.Write("Enter First Number:");
           n1 = System.Convert.ToInt16(System.Console.ReadLine());
       
           System.Console.Write("Enter Second Number:");
           n2 = System.Convert.ToInt16(System.Console.ReadLine());
       
           System.Console.Write("Select Operation (+ , - , * , /) = ");
           op = System.Convert.ToChar(System.Console.ReadLine());
       
          switch(op)

          {
           case '+':
           result = n1 + n2;
           System.Console.Write("Addition is = "+result);
           break;
           
           case '-':
           result = n1 - n2;
           System.Console.Write("Subtraction is = "+result);
           break;
           
           case '*':
           System.Console.Write("Multiplication is = "+result);
           break;
           
           case '/':
           System.Console.Write("Division is = "+result);
           break;

           default:
           System.Console.Write("Invalid Operation Selected...");
           break;
          
           }
       
        }
    }
}
