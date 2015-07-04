using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        //Guess Number Program for the Interview Phase 2 - Segment 2
        //by Dulan Chiranthaka 2015-07-03

        const int GUESSES = 3; // number of guesses
        const int LUCKY_NO = 42; // the number to be guessed.

        static void Main(string[] args)
        {
            //Guess the number Interview phase 2 Segment 2
            int number = 0;

            for (int i = 0; i < GUESSES; i++)
            {
                Console.WriteLine("Please enter a number between 1 - 100 :");
                try
                {

                    number = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Number!");
                    continue;
                }


                if (number == LUCKY_NO)
                {
                    Console.WriteLine("Correct");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
