// Дано время в часах и минутах. Найти угол от часовой к минутной стрелке на обычных часах.

double h, m;

Console.WriteLine("Введите час: ");
h = double.Parse(Console.ReadLine());

Console.WriteLine("Введите минуты: ");
m = double.Parse(Console.ReadLine());

Console.WriteLine($"Время {h.ToString("00")}:{m.ToString("00")}");
Console.WriteLine($"Угол между стрелками: {Angel(h, m).ToString("F1")} °C");
Console.ReadLine();

double Angel(double h, double m)
{
    m %= 60;

    double hOffset = h % 12;
    hOffset += (1f / 60) * m;


    double hAng = (360 / 12) * hOffset;
    double mAng = (360 / 60) * m;

    // результат
    double result = Math.Abs(hAng - mAng);
    result = result > 180 ? 360 - result : result;
    return result;
}


