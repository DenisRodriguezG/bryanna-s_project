﻿/* Bryanna Jones, November 29, Problem 1 */

using System;

namespace secondproject
{
    class Program
    {
        static void Main(string[] args)
        {
            string words;
            char entered = ' ';
            

           do
            {
                Console.WriteLine("Please enter e(encode), d(decode), s(secret), " + "or q(quit).");
                entered = Console.ReadLine();
                if (entered == 'q' || entered == 'Q')
                {
                    Console.WriteLine("Game Over !!");
                    break;
                }

                if (entered == 'e' || entered == 'E')
                {
                    Console.WriteLine("Please enter a sentence");
                    words = Console.ReadLine();
                    char[] phrase = new char[words.Length];
                    Console.WriteLine($"Your endoded message is {DecoderRing.Encode(words)}.");
                }

                else if (entered == 'd' || entered == 'D')
                {
                    Console.WriteLine("Please enter a sentence");
                    words = Console.ReadLine();
                    char[] phrase = new char[words.Length];
                    Console.WriteLine($"Your decoded message is {DecoderRing.Decode(words)}.");
                }
                else if (entered == 's' || entered == 'S')
                {
                    Console.WriteLine("Please enter a sentence");
                    words = Console.ReadLine();
                    char[] phrase = new char[words.Length];
                    Console.WriteLine($"Your secret message is {DecoderRing.Secret(words)}.");
                }
                else
                {
                    Console.WriteLine("Please enter e(encode), d(decode), s(secret), " +  "or q(quit)");
                    entered = Console.ReadLine();
                }
            } while (entered != ' ') ;










        }
    }
}
