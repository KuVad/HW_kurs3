// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа: ");
int x1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int x3 = int.Parse(Console.ReadLine());
int Maximum = x1;

if (x2 > Maximum)   Maximum = x2;
if (x3 > Maximum)   Maximum = x3;

Console.WriteLine($"Максимальное число: {Maximum}");
