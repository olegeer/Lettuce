﻿using System;
using System.Linq;
namespace Lettuce
{
    class main
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(LettuceRandom.NextBool(1, 7));
            }
        }
    }
}