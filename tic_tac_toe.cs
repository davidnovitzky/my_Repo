char[] ticTacToe = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

while (true)
{
    Console.Clear();
    DisplayBoard();

    Console.Write("What square do you want to choose? ");
    char.TryParse(Console.ReadLine(), out char square);

    if (square == '1')
    {
        ticTacToe[0] = square;
        ticTacToe[0] = 'X';
    }

    if (square == '2')
    {
        ticTacToe[1] = square;
        ticTacToe[1] = 'O';
    }
}

void DisplayBoard()
{
    Console.WriteLine($" {ticTacToe[0]} | {ticTacToe[1]} | {ticTacToe[2]}");
    Console.WriteLine("---|---|---");
    Console.WriteLine($" {ticTacToe[3]} | {ticTacToe[4]} | {ticTacToe[5]}");
    Console.WriteLine("---|---|---");
    Console.WriteLine($" {ticTacToe[6]} | {ticTacToe[7]} | {ticTacToe[8]}");
}
