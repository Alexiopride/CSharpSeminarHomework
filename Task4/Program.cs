// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Enter natural number: ");
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