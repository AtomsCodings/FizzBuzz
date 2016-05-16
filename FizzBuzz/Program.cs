/******************************************************************************************************
             Instructions for writing this console application:

             Write a program that can be given a start and end integer and iterate over every number in that range.

             When the number is a multiple of three mark it as Fizz.
             When the number is a multiple of five mark it as Buzz.
             When a number is a multiple of three and five mark it as FizzBuzz.

             The program should show the list to the user when it is done.

             Author: A Thomas  Last Updated: 16/03/16

********************************************************************************************************/

using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNo = 0;
            int endNo = 0;
            int i = 0;

            String fizz = "fizz";
            String buzz = "buzz";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("Enter a start and end integer, and the program will iterate over every number in that range.");
            Console.WriteLine(" When the number is a multiple of three it will be marked as Fizz.");
            Console.WriteLine(" When the number is a multiple of five it will be marked as Buzz.");
            Console.WriteLine(" When the number is a multiple of three and five, it will be marked as FizzBuzz.");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("Please enter your starting number: ");

            try
            {
                startNo = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your final number: ");
                try
                {
                    endNo = Int32.Parse(Console.ReadLine());
                    if (endNo < startNo)
                    {
                        Console.WriteLine("Your final number is smaller than your start number. Try again with your starting number being smaller than your final number.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine();
                        while (startNo <= endNo)
                        {
                            Console.Write(startNo + " ");

                            if ((startNo + i) != 0)
                            {
                                if ((startNo + i) % 3 == 0)
                                {
                                    Console.Write(fizz);
                                }
                                if ((startNo + i) % 5 == 0)
                                {
                                    Console.Write(buzz);
                                }
                            }
                            Console.WriteLine();
                            startNo++;
                        }
                    }
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Your final number is not an integer.  Please try again.");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Your starting number is not an integer.  Please try again.");
                Console.ReadKey();
            }
        }
    }
}
