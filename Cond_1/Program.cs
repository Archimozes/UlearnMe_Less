// Дана начальная и конечная клетки на шахматной доске.
// Корректный ли это ход на пустой доске для: слона, коня, ладьи, ферзя, короля?

Cond1();

static void Cond1()
{
    while (true)
    {
        string[] input = Console.ReadLine().Split();
        string start = input[0];
        string finish = input[1];
        if (start == finish)
        {
            Console.WriteLine("You haven't made a turn");
            continue;
        }
        int x1 = (int)start[0] % 32;
        int y1 = (int)start[1];
        int x2 = (int)finish[0] % 32;
        int y2 = (int)finish[1];
        bool okForRook = (x1 == x2 || y1 == y2);
        bool okForKnight = (Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 1) || (Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 2);
        bool okForBishop = Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        bool okForQueen = okForRook || okForBishop;
        bool okForKing = (Math.Abs(x1 - x2) <= 1) && (Math.Abs(y1 - y2) <= 1);
        Console.WriteLine("Rook: " + okForRook);
        Console.WriteLine("Knight: " + okForKnight);
        Console.WriteLine("Bishop: " + okForBishop);
        Console.WriteLine("Queen: " + okForQueen);
        Console.WriteLine("King: " + okForKing);
    }
}