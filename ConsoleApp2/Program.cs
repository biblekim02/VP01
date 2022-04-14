int Fact(int n)
{
    if (n == 1) return 1;
    else return n * Fact(n - 1);
}

Console.Write("정수 하나를 입력하시오. : ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine(i + "! : " + Fact(i));
}
