﻿using System;

namespace example1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.WriteLine("Enter a value for a: ");
            a =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value for b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Adding {a} * {b} equals {Addnumbers(a, b)}");

        }

        //Funcionalidad cambiada a resta y nombre de función actualizado
        public static int SubstractNumbers(int a, int b)
        {
            return a - b;

        }
        
    }
}
