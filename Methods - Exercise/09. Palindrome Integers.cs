﻿using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string command = string.Empty;
            IsItPalindrome(command);

        }
        static void IsItPalindrome(string command)
        {
            string reversed = string.Empty;

            while (command != "END")
            {
                command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reversed += command[i];
                }

                if (reversed != command)
                {
                    Console.WriteLine("false");
                }
                else if (reversed == command)
                {
                    Console.WriteLine("true");
                }
                reversed = string.Empty;
            }
        }
    }
}

