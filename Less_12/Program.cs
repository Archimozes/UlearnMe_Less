
Expr12();
/// <summary>
/// Задача с тимуса 1885. Комфорт пассажиров
/// </summary>
static void Expr12()
{
    //x*t1 + v*t2 = h; t1 + t2 = t. Решаем систему, находим t2.
    //Если t2 неположительно, значит можем весь путь лететь со скоростью x, 
    //а max находим при движении со скоростью x + epsilon.
    //Вообще идея в том что нам нужно лететь максимально долго с максимальной скоростью, 
    //при которой не закладывает уши. Это скорость x, так мы получаем min.
    double h, t, v, x;
    Console.WriteLine("Введите h, t, v, x через пробел");
    string[] input = Console.ReadLine().Split();
    h = int.Parse(input[0]);
    t = int.Parse(input[1]);
    v = int.Parse(input[2]);
    x = int.Parse(input[3]);

    double min, max, tBlocked;
    tBlocked = (h - t * x) / (v - x);
    if (tBlocked <= 0)
    {
        min = 0;
        max = h / x;
    }
    else
    {
        min = tBlocked;
        max = t;
    }
    Console.WriteLine(min + " " + max);
}