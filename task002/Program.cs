// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Write a namber a, b and c: ");
int a, b, c;
if (int.TryParse (Console.ReadLine(), out a) && int.TryParse (Console.ReadLine(), out b) && int.TryParse (Console.ReadLine (), out c))
    
    if (a > b)
    {
        if ( a > c)
        {
        Console.Write("max: ");
        Console.Write(a);
        }
        else 
        {
            if ( b > c )
            {
                Console.Write("max: ");
                Console.Write(b);
            }
            else 
            {
                Console.Write("max: ");
                Console.Write(c);
            }
         }

    }

    else 
    {
        Console.Write("max: ");
        Console.WriteLine(c);
    }

else 
{
    Console.WriteLine ("It's not a number");
}

