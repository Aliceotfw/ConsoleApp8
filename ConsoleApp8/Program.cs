using System.Data.Common;
using System.Runtime.InteropServices;

ShowInConsole();

 void ShowInConsole()
{
    Console.Write("Enter Figure name: ");
    string figureName = Console.ReadLine();
    figureName = figureName.ToUpper();
    Console.Write("Enter coordinate1: ");
    string coord1 = Console.ReadLine();
    coord1 = coord1.ToUpper();
    Console.Write("Enter coordinate2: ");
    string coord2 = Console.ReadLine();
    coord2 = coord2.ToUpper();

    PrintBoard(coord1, figureName);
    Console.WriteLine();

    switch (figureName)
    {
        case "ROOK":
            Console.WriteLine(CheckRookCoord(coord1, coord2));
            if (CheckRookCoord(coord1, coord2))
                PrintBoard(coord2, figureName);
            break;
        case "KNIGHT":
            Console.WriteLine(CheckKnightCoord(coord1, coord2));
            if (CheckKnightCoord(coord1, coord2))
                PrintBoard(coord2, figureName);
            break;
        case "BISHOP":
            Console.WriteLine(CheckBishopCoord(coord1, coord2));
            if (CheckBishopCoord(coord1, coord2))
                PrintBoard(coord2, figureName);
            break;
        case "QUEEN":
            Console.WriteLine(CheckQueenCoord(coord1, coord2));
            if (CheckQueenCoord(coord1, coord2))
                PrintBoard(coord2, figureName);
            break;
        case "KING":
            Console.WriteLine(CheckKingCoord(coord1, coord2));
            if (CheckKingCoord(coord1, coord2))
                PrintBoard(coord2, figureName);
            break;
    }
}
bool CheckRookCoord(string coord1, string coord2)
{
    char column1 = coord1[0];
    int row1 = int.Parse(coord1.Substring(1));
    char column2 = coord2[0];
    int row2 = int.Parse(coord2.Substring(1));

    int rowDifference = Math.Abs(row2 - row1);
    int columnDifference = Math.Abs(column2 - column1);

    return (rowDifference == 0 && columnDifference != 0) || (rowDifference !=0 && columnDifference == 0);
}

bool CheckKnightCoord(string coord1, string coord2)
{
    char column1 = coord1[0];
    int row1 = int.Parse(coord1.Substring(1));
    char column2 = coord2[0];
    int row2 = int.Parse(coord2.Substring(1));

    int rowDifference = Math.Abs(row2 - row1);
    int columnDifference = Math.Abs(column2 - column1);

    return (rowDifference == 2 && columnDifference == 1) || (rowDifference == 1 && columnDifference == 2);
}
bool CheckBishopCoord(string coord1, string coord2)
{
    char column1 = coord1[0];
    int row1 = int.Parse(coord1.Substring(1));
    char column2 = coord2[0];
    int row2 = int.Parse(coord2.Substring(1));

    int rowDifference = Math.Abs(row2 - row1);
    int columnDifference = Math.Abs(column2 - column1);

    return rowDifference == columnDifference;
}

bool CheckQueenCoord(string coord1, string coord2)
{
    char column1 = coord1[0];
    int row1 = int.Parse(coord1.Substring(1));
    char column2 = coord2[0];
    int row2 = int.Parse(coord2.Substring(1));

    int rowDifference = Math.Abs(row2 - row1);
    int columnDifference = Math.Abs(column2 - column1);

    return (rowDifference == columnDifference) ||  (columnDifference == 0) || (rowDifference == 0);
}
bool CheckKingCoord(string coord1, string coord2)
{
    char column1 = coord1[0];
    int row1 = int.Parse(coord1.Substring(1));
    char column2 = coord2[0];
    int row2 = int.Parse(coord2.Substring(1));

    int rowDifference = Math.Abs(row2 - row1);
    int columnDifference = Math.Abs(column2 - column1);

    return (rowDifference <= 1 && columnDifference==1) || (rowDifference == 1 && columnDifference <= 1);
}

void PrintBoard(string coord1, string figure)
{
    char chFigure = Convert.ToChar(figure[0]);
    if (figure == "Knight")
        chFigure ='N';
    char column = coord1[0];
    int row = int.Parse(coord1.Substring(1));
    char[] ch = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
    Console.Write(" ");
    foreach (char ch2 in ch)
        Console.Write(" " + ch2 + " ");

    Console.WriteLine();

    for (int i = 1; i < 9; i++)
    {
        
        Console.Write(i);
        for (char j = 'A'; j <= 'H'; j++)
        {
            
            if ((i + (int)j) % 2 == 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            if (i == row && j == column)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" " + chFigure + " ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   ");
            }
                Console.ResetColor();

        }

        
        Console.Write(i);
        
        Console.WriteLine();
    }

    Console.Write(" ");
    foreach (char ch2 in ch)
        Console.Write(" " + ch2 + " ");
}  

