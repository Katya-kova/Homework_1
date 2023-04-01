//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Write a namber a and b: ");
int a;
int b;
if (int.TryParse (Console.ReadLine(), out a) && int.TryParse (Console.ReadLine(), out b))
    
    if (a > b)
    {
        Console.Write("max: ");
        Console.Write(a);
        Console.Write("min: ");
        Console.Write(b);
    }
    else 
    {
        Console.Write("max: ");
        Console.WriteLine(b);
        Console.Write("min: ");
        Console.Write(a);
    }

else 
{
    Console.WriteLine ("It's not a number");
}
