// Vi ska spela FizzBuzz
// Man börjar räkna från 1 och sedan till 260
// Varje gång man kommer till något som är delbart med 3 ska consolen skriva ut Fizz
// Varje gång man kommer till något som är delbart med 5 ska consolen skriva ut Buzz
// Varje gång man kommer till något som är delbart med 7 ska consolen skriva ut Bazz
// Varje gång man kommer till något som är delbart med 15 ska consolen skriva ut FizzBuzz
// Varje gång man kommer till något som är delbart med 21 ska consolen skriva ut FizzBazz
// Varje gång man kommer till något som är delbart med 35 ska consolen skriva ut BuzzBazz
// Varje gång man kommer till något som är delbart med 105 ska consolen skriva ut FizzBuzzBazz

/*
int n = 1;

while (n != 265)
{
    if(n % 105 != 0)
    {
        if (n % 15 != 0 && n % 21 != 0 && n % 35 != 0) 
        {
            if (n % 3 != 0 && n % 5 != 0 && n % 7 != 0)
            {
                Console.WriteLine(n);
            }
            else if (n % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (n % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (n % 7 == 0)
            {
                Console.WriteLine("Bazz");
            }
        }

    }
    

    n = n + 1;
}

*/

for (int i = 1; i <= 255; i++)
{
    
    if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
    {
        Console.WriteLine("FizzBuzzBazz");
    }
    else if (i % 5 == 0 && i % 7 == 0)
    {
        Console.WriteLine("BuzzBazz");
    }
    else if (i % 3 == 0 && i % 7 == 0)
    {
        Console.WriteLine("FizzBazz");
    }
    else if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 7 == 0)
    {
        Console.WriteLine("Bazz");
    }
    else
    {
        Console.WriteLine(i);
    }
}