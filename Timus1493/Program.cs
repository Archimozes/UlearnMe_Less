// Дан номер трамвайного билета, в котором суммы первых трёх цифр
// и последних трёх цифр отличаются на 1 (но не сказано, в какую сторону).
// Правда ли, что предыдущий или следующий билет счастливый?

Timus1493();

static void Timus1493()
{
    var inputString = Console.ReadLine();
    var sumLeft = inputString.Substring(0, 3).ToArray().Select(c => int.Parse(c.ToString())).Sum();
    var sumRight = inputString.Substring(3).ToArray().Select(c => int.Parse(c.ToString())).Sum();
    var numRight = int.Parse(inputString.Substring(3));
    if ((sumLeft > sumRight && numRight % 10 != 9) || (sumLeft < sumRight) && (numRight % 10 != 0))
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}
