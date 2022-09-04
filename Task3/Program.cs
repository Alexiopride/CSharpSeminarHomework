// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Number is even"); 
}
else 
{
    Console.WriteLine("Number isn't even");
}