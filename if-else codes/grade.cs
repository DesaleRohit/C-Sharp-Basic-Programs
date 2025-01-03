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
            
          float math,os,cpp,wd,total,per=0;
      
          System.Console.Write("\nEnter the Marks of Mathematics:");
          math = System.Convert.ToInt16(System.Console.ReadLine());
      
          System.Console.Write("\nEnter Marks of Operating System:");
          os = System.Convert.ToInt16(System.Console.ReadLine());
      
          System.Console.Write("\nEnter Marks of CPP:");
          cpp = System.Convert.ToInt16(System.Console.ReadLine());
    
          System.Console.Write("\nEnter Marks of Web Development-I:");
          wd = System.Convert.ToInt16(System.Console.ReadLine());
      
          total = (math + os + cpp + wd);
          per = ((total / 400)*100);
      
          if(per >= 35 && per < 55)
          {
              System.Console.Write("\n Student Pass with D Grade");
          }
          else if(per >= 55 && per < 70)
          {
               System.Console.Write("\n Student Pass with C Grade");
          }
              else if(per >= 70 && per < 85)
          {
               System.Console.Write("\n Student Pass with B Grade");
          }
          else if(per >= 85 && per < 100)
          {
               System.Console.Write("\n Student Pass with A Grade");
           }
           else 
          {
               System.Console.Write("\n Student is Fail..");
          }
        }
    }
}
