﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

     int result;
   
            int enterNumberA, enterNumberB;

            Console.WriteLine("Для формулы A^B");
            Console.Write("Введите число A: ");
            enterNumberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            enterNumberB = Convert.ToInt32(Console.ReadLine());

            result = enterNumberA;

            for (int i = 2; i <= enterNumberB; i++)
            {
                result *= enterNumberA;
            }

            Console.WriteLine($"{enterNumberA}^{enterNumberB} = {result}");