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
            int n1,n2,op;
     string ch="null";
     System.Console.Write("1. Addition");
     System.Console.Write("\n 2. Subtraction");
     System.Console.Write("\n 3. Multiplication");
     System.Console.Write("\n 4. Division");
    
    do
    {
        System.Console.Write("\nEnter the First Number : ");
        n1 = System.Convert.ToInt16(System.Console.ReadLine());
        System.Console.Write("\nEnter the Second Number : ");
        n2 = System.Convert.ToInt16(System.Console.ReadLine());
        System.Console.Write("\nEnter the Operation Number: ");
        op = System.Convert.ToChar(System.Console.ReadLine());
        
        switch (op)
        {
            case '1':
            System.Console.Write("\nAddition ="+(n1+n2));
            break;
            
            case '2':
            System.Console.Write("\nAddition ="+(n1+n2));
            break;
            
            case '3':
            System.Console.Write("\nAddition ="+(n1+n2));
            break;
            
            case '4':
            System.Console.Write("\nAddition ="+(n1+n2));
            break;
            
            default:
            System.Console.Write("\n Invalid Operation Number");
            break;
        }
        System.Console.Write("\nDo you want to perform another calculation(Yes/NO): ");
        ch = System.Console.ReadLine();
        if(ch == "No")
        {
            System.Console.Write("Done");
        }
        else if(ch == "Yes")
        {
            System.Console.Write("\n");
        }
        else
        {
            System.Console.Write("Invalid value");
        }
        
    }
    while(ch == "Yes");
        }
    }
}
