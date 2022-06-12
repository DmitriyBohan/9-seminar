﻿/*
Задача 69: 
Напишите программу, которая на вход 
принимает два числа A и B, и возводит число А 
в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/


int NumberPow(int number, int pow)
{
    if (pow == 0)
    {
        return 1;
    }

    if (pow > 0)
    {
        return NumberPow(number, pow - 1) * number;
    }
    return NumberPow(number, pow - 1);
}
System.Console.WriteLine("Результат возведения в степень равен:", NumberPow(3, 5));



