// Нужно проехать L километров так,
// чтобы любой отрезок пути длиной K километров (K ≤ L) проезжать ровно за H часов.
// Какое минимальное и максимальное время для этого понадобится?

Timus1740();

static void Timus1740()
{
    string[] input = Console.ReadLine().Split();
    var l = int.Parse(input[0]);
    var k = int.Parse(input[1]);
    var h = int.Parse(input[2]);
    double minTime = l / k * h;
    double maxTime = l % k == 0 ? minTime : minTime + h - .00001;
    Console.WriteLine(String.Format("{0:F5} {1:F5}", minTime, maxTime));
}