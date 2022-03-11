Expr13();

/// <summary>
/// Задача с тимуса 1084. Пусти козла в огород
/// </summary>
static void Expr13()
{
    //Идея: 2 случая, если радиус круга меньше половины стороны квадрата;
    //если больше, то считаем площади секторов без крышечек
    string[] input = Console.ReadLine().Split();
    double side, cord;
    side = double.Parse(input[0]);
    cord = double.Parse(input[1]);
    double result;
    if (cord < side / 2)
    {
        result = Math.PI * Math.Pow(cord, 2);
    }
    else if (cord >= Math.Sqrt(2 * Math.Pow(side, 2)) / 2)
    {
        result = Math.Pow(side, 2);
    }
    else
    {
        double sinAuxAngle = (side / 2) / cord;
        double angle = Math.PI - 2 * Math.Asin(sinAuxAngle);
        double areaSector = Math.PI * Math.Pow(cord, 2) * angle / (2 * Math.PI);
        double areaTriangle = Math.Pow(cord, 2) * Math.Sin(angle) / 2;
        result = Math.PI * Math.Pow(cord, 2) - (areaSector - areaTriangle) * 4;
    }
    Console.WriteLine(String.Format("{0:F3}", result));
}
