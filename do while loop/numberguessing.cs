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
            Random number = new Random();
            int num, guess;

            do
            {
                guess = number.Next(1, 100);
                System.Console.Write("\n Enter the Number:");
                num = System.Convert.ToInt16(System.Console.ReadLine());

                if(num == guess)
                {
                    System.Console.Write("\n Congratulation!! You Have Guessed Correct Number");
                    break;
                }
                else
                {
                    System.Console.Write("\n Incorrect Guess..");
                }
            } while(num != guess);
            System.Console.Read();
        }
    }
}
