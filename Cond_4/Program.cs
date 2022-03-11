//  Пересечение двух отрезков [A,B] и [C,D] на числовой прямой.
//  Найти красивое решение, то есть наиболее ясное и краткое.
Cond4();

static void Cond4()
{
    int[] input = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
    int diff = Math.Min(input[1], input[3]) - Math.Max(input[0], input[2]);
    Console.WriteLine(diff > 0 ? diff : 0);
}