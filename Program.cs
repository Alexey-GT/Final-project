/*
//64
//
Console.Clear();
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
FuncRecOut(n);

int FuncRecOut(int n)
{
    if (n == 1)
    {
        Console.Write($" {n}");
        return 1;
    }
    else
    {
        Console.Write($" {n},");
        return (FuncRecOut(n-1));
    }
}
*/

/*
//66
//
Console.Clear();
Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(FuncRecSum(n));

int FuncRecSum(int n)
{
    if (n > m)
    {
        n--;
        int sum = FuncRecSum(n);
        return sum + n + 1;
    }
    else
    {
        return m;
    }
}
*/


/* 
//68
//
Console.Clear();
Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write($"A({m},{n}) = {FuncAckermann(m, n)}");

int FuncAckermann(int m, int n)
{
    if (m > 0 && n > 0)
    {
        return FuncAckermann(--m, FuncAckermann(++m, --n));
    }
    else
    {
        if (m > 0 && n == 0)
        {
            return FuncAckermann(--m, 1);
        }
        else
        {
            return n + 1;
        }
     }
}  */