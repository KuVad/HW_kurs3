﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int CurrentNum = 2;

while (CurrentNum <= number)
{
    Console.Write(CurrentNum + " ");
    CurrentNum = CurrentNum + 2;
}