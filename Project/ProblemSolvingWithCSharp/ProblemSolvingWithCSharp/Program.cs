﻿using ProblemSolvingWithCSharp.EasyProlem;
using System;

namespace ProblemSolvingWithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new int[2, 4];

            var input = new int[] { 1, 2, 3, 5, 6, 8, 9 };
            SortedSquaredArray.Sol3(input);
            Console.WriteLine(ReverseSting.GetReverse( "Mitul!"));

            
        }
    }
}
