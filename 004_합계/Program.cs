int ssum = 0;
int esum = 0;
int osum = 0;
double rsum = 0;

for (int i = 1; i <= 100; i++)
{
    ssum += i;
    rsum += 1.0 / i;
    if (i % 2 == 0) esum += i;
    else osum += i;
}

Console.WriteLine("1~100 합 : " + ssum);
Console.WriteLine("1~100 짝수 합 : " + esum);
Console.WriteLine("1~100 홀수 합 : " + osum);
Console.WriteLine("1~100 역수 합 : {0:0.0000}", rsum);

