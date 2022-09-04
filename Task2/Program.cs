// ____________________________________________________________________
// Задача 2.
// Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел
// ____________________________________________________________________

Console.WriteLine("Enter first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max) max = num2; 
if (num3 > max) max = num3; 

Console.Write("max = ");
Console.WriteLine(max);