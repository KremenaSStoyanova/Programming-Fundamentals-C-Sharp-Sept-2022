﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers  = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] < 0)
            //    {
            //        numbers.Remove(numbers[i]);
            //        i--;
            //    }
            //}

            numbers.RemoveAll(x => x < 0); // премахва всички отрицателни числа

            numbers.Reverse(); // обръща числата в обратен ред

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
