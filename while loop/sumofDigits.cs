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
            int num, r , sum=0;
            System.Console.Write("\nEnter any Number : ");
            num = System.Convert.ToInt16(System.Console.ReadLine());
            while (num > 0)
            {
              r = num % 10;
              sum = sum + r;
              num = num / 10;
            }
              System.Console.Write("\nAnswer is : "+sum);
        }
    }
}
