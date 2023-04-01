// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Write a number: ");
int i;
if (int.TryParse (Console.ReadLine(), out i))
{
    if ( i % 2 == 0)
    {
        Console.WriteLine("Ever numder");
    }
    else 
    {
        Console.WriteLine("Odd number");
    }
}
else
{
    Console.WriteLine("It's not a number");
}
