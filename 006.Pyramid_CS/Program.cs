int n = 120;


for(int i = 1; i <= n; i++)
{
    for (int j = 0; j < n - i; j++)
    {
        Console.Write(" ");
    }
    for(int k = 0;k<i*2-1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.Write("안녕 다원 {0:0.0000}",5.123456789);