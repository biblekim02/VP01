Random r = new Random();
int[] a = new int[10];

for (int i = 0; i < 10; i++)
{
    a[i] = r.Next(100);
}

foreach (var i in a)
{
    Console.Write(i + " ");
}
Console.WriteLine();

int min = a[0]; int max = a[0];

for (int i = 1; i < 10; i++)
{
    if (a[i] < min) min = a[i];
    else if (a[i] > max) max = a[i];
}

Console.WriteLine("최솟값 : " + min);
Console.WriteLine("최댓값 : " + max);