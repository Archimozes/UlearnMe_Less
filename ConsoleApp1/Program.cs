
// 1 Option
var sum = Enumerable.Range(0, 1000).Where(i => i % 3 == 0 | i % 5 == 0).Sum();
Console.WriteLine(sum);

// 2 option
sum = 0;
for (int i = 0; i < 1000; i++)
{
    if (i % 3 == 0 | i % 5 == 0)
    {
        sum += i;
    }
}

Console.WriteLine(sum);
