// ____________________________________________________________________
// Задача 4.
// Напишите программу, которая на вход принимает число (N)
//  а на выходе показывает все чётные числа от 1 до N.
// ____________________________________________________________________
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int currentNumber = 1;

while (currentNumber <= number)
{
    if (currentNumber % 2 == 0)
    {
        Console.WriteLine(currentNumber); 
    }
    currentNumber++;
}    