void Cube( int N)
{
    Console.Write($"{N} --> ");
    int i = 1;
    while (i < N)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
        i++;
    }
    Console.WriteLine($"{Math.Pow(N,3)}.");
}
Cube(3);
Cube(5);