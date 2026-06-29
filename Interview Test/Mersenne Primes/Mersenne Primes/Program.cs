using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

int[] primes = [];
int[] mprimes = [2];

bool A = false;
bool check = true;
long Count = 3;

while (!A)
{
    
    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

        if (keyInfo.Key == ConsoleKey.Spacebar)
        {
            Console.WriteLine("STOP");
            A = true;
        }
    }
    check = true;
    for (int i = 3; i <= (long)Math.Floor(Math.Sqrt(Count)); i += 2)
    {
        if (Count % i == 0)
        {
            check = false;
        }
    }
    if (check == false)
    {
        Count += 2;
    }
    else
    { 
        for (int i = 3; i <= (long)Math.Floor(Math.Sqrt(Math.Pow(2,Count) - 1)); i += 2)
        {
            if ((Math.Pow(2, Count) - 1) % i == 0)
            {
                check = false;
            }
        }
        if (check == true)
        {
            Console.WriteLine("2^" + Count + " - 1"  + "= " + ((long)Math.Pow(2, Count) - 1).ToString("F0"));
            Count += 2;
        }
        else
        {
            Count += 2;
        }
    }
}

