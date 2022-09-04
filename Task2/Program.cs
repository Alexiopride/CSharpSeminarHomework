// Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Enter first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
if (secondNumber > max) max = secondNumber; 
if (thirdNumber > max) max = thirdNumber; 

Console.Write("max = ");
Console.WriteLine(max);