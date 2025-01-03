using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
       int n1,n2;
       System.Console.Write("\n Enter the Starting Number:");
       n1 = System.Convert.ToInt16(System.Console.ReadLine());
       System.Console.Write("\n Enter the Ending Number");
       n2 = System.Convert.ToInt16(System.Console.ReadLine());
       
       int i = n1;
       do
       {
           if( i % 2!= 0 )
           {
               System.Console.Write("\t"+i+"\n");
           }
           i++;
       }
       while( i <= n2);
        }
    }
}
