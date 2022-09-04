// ____________________________________________________________________
// Задача 1.
// Напишите программу, которая на вход принимает два числа
// и выдаёт какое число большее а какое меньшее.
// ____________________________________________________________________

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = 0; 
int min = 0;

if (num1 > num2) 
{
    max = num1;
    min = num2;
    Console.Write("max = ");
    Console.WriteLine(num1);
    Console.Write("min = ");
    Console.WriteLine(num2);
}
else 
{
    max = num2;
    min = num1;
    Console.Write("max = ");
    Console.WriteLine(num2);
    Console.Write("min = ");
    Console.WriteLine(num1);
} 