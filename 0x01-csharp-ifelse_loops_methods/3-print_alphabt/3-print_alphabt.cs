﻿using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char alphabet = 'a'; alphabet <= 'z'; alphabet++)
            {
                if (alphabet != 'e')
                    Console.Write(alphabet);
            }
        }
    }
}
