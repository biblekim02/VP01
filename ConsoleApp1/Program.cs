void Hanoi(int x,char from,char via,char to)
{
    if (x == 1) Console.WriteLine("{0} -> {1}", from, to);
    else
    {
        Hanoi(x - 1, from, to, via);
        Console.WriteLine("{0} -> {1}", from, to);
        Hanoi(x - 1, via,from, to);
    }
}
Hanoi(4, 'A', 'B', 'C');