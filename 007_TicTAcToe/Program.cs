// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tic Tac Toe");

var r1c1 = "*";
var r1c2 = "*";
var r1c3 = "*";
var r2c1 = "*";
var r2c2 = "*";
var r2c3 = "*";
var r3c1 = "*";
var r3c2 = "*";
var r3c3 = "*";

string win = string.Empty;

do
{

    #region Player1
    Console.Clear();

    Console.WriteLine($" {r1c1} | {r1c2} | {r1c3} ");
    Console.WriteLine($" {r2c1} | {r2c2} | {r2c3} ");
    Console.WriteLine($" {r3c1} | {r3c2} | {r3c3} ");



    Console.WriteLine("Player X, please enter your move: ");
    Console.WriteLine("Row: ");
    var row = int.Parse(Console.ReadKey().KeyChar.ToString());
    Console.WriteLine("Column: ");
    var column = int.Parse(Console.ReadKey().KeyChar.ToString());
    #region check !="*"
    if (row == 1)
    {
        if (column == 1)
        {
            if (r1c1 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r1c1 = "X";
            }
        }
        else if (column == 2)
        {
            if (r1c2 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r1c2 = "X";
            }
        }
        else
        {
            if (r1c3 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r1c3 = "X";
            }
        }
    }
    else if (row == 2)
    {
        if (column == 1)
        {
            if (r2c1 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r2c1 = "X";
            }
        }
        else if (column == 2)
        {
            if (r2c2 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r2c2 = "X";
            }
        }
        else
        {
            if (r2c3 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r2c3 = "X";
            }
        }
    }
    else if (row == 3)
    {
        if (column == 1)
        {
            if (r3c1 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r3c1 = "X";
            }
        }
        else if (column == 2)
        {
            if (r3c2 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r3c2 = "X";
            }
        }
        else
        {
            if (r3c3 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r3c3 = "X";
            }
        }
    }
    #endregion

    #endregion
    Console.Clear();
    Console.WriteLine($" {r1c1} | {r1c2} | {r1c3} ");
    Console.WriteLine($" {r2c1} | {r2c2} | {r2c3} ");
    Console.WriteLine($" {r3c1} | {r3c2} | {r3c3} ");
    #region Check for win
    if (r1c1 == r1c2 && r1c2 == r1c3 && r1c1 != "*")
    {
        win = "X";
    }
    else if (r2c1 == r2c2 && r2c2 == r2c3 && r2c1 != "*")
    {
        win = "X";
    }
    else if (r3c1 == r3c2 && r3c2 == r3c3 && r3c1 != "*")
    {
        win = "X";
    }
    else if (r1c1 == r2c1 && r2c1 == r3c1 && r1c1 != "*")
    {
        win = "X";
    }
    else if (r1c2 == r2c2 && r2c2 == r3c2 && r1c2 != "*")
    {
        win = "X";
    }
    else if (r1c3 == r2c3 && r2c3 == r3c3 && r1c3 != "*")
    {
        win = "X";
    }
    else if (r1c1 == r2c2 && r2c2 == r3c3 && r1c1 != "*")
    {
        win = "X";
    }
    else if (r1c3 == r2c2 && r2c2 == r3c1 && r1c3 != "*")
    {
        win = "X";
    }
    else if (r1c1 !="*" && r1c2 != "*" && r1c3 != "*" && r2c1 != "*" && r2c2 != "*" && r2c3 != "*" && r3c1 != "*" && r3c2 != "*" && r3c3 != "*")
    {
        win = "No player";
    }
    #endregion

    #region break;
    if (!string.IsNullOrEmpty(win))
    {
        break;
    }
    #endregion

    #region Player2
    Console.Clear();
    Console.WriteLine($" {r1c1} | {r1c2} | {r1c3} ");
    Console.WriteLine($" {r2c1} | {r2c2} | {r2c3} ");
    Console.WriteLine($" {r3c1} | {r3c2} | {r3c3} ");
    Console.WriteLine("Player O, please enter your move: ");
    Console.WriteLine("Row: ");
    row = int.Parse(Console.ReadKey().KeyChar.ToString());
    Console.WriteLine("Column: ");
    column = int.Parse(Console.ReadKey().KeyChar.ToString());
    #region check !="*"
    if (row == 1)
    {
        if (column == 1)
        {
            if (r1c1 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r1c1 = "O";
            }
        }
        else if (column == 2)
        {
            if (r1c2 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r1c2 = "O";
            }
        }
        else
        {
            if (r1c3 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r1c3 = "O";
            }
        }
    }
    else if (row == 2)
    {
        if (column == 1)
        {
            if (r2c1 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r2c1 = "O";
            }
        }
        else if (column == 2)
        {
            if (r2c2 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r2c2 = "O";
            }
        }
        else
        {
            if (r2c3 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r2c3 = "O";
            }
        }
    }
    else if (row == 3)
    {
        if (column == 1)
        {
            if (r3c1 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r3c1 = "O";
            }
        }
        else if (column == 2)
        {
            if (r3c2 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r3c2 = "O";
            }
        }
        else
        {
            if (r3c3 != "*")
            {
                Console.WriteLine("Place is taken");
            }
            else
            {
                r3c3 = "O";
            }
        }
    }
    #endregion

    #endregion

    Console.Clear();
    Console.WriteLine($" {r1c1} | {r1c2} | {r1c3} ");
    Console.WriteLine($" {r2c1} | {r2c2} | {r2c3} ");
    Console.WriteLine($" {r3c1} | {r3c2} | {r3c3} ");
    #region Check for win
    if (r1c1 == r1c2 && r1c2 == r1c3 && r1c1 != "*")
    {
        win = "O";
    }
    else if (r2c1 == r2c2 && r2c2 == r2c3 && r2c1 != "*")
    {
        win = "O";
    }
    else if (r3c1 == r3c2 && r3c2 == r3c3 && r3c1 != "*")
    {
        win = "O";
    }
    else if (r1c1 == r2c1 && r2c1 == r3c1 && r1c1 != "*")
    {
        win = "O";
    }
    else if (r1c2 == r2c2 && r2c2 == r3c2 && r1c2 != "*")
    {
        win = "O";
    }
    else if (r1c3 == r2c3 && r2c3 == r3c3 && r1c3 != "*")
    {
        win = "O";
    }
    else if (r1c1 == r2c2 && r2c2 == r3c3 && r1c1 != "*")
    {
        win = "O";
    }
    else if (r1c3 == r2c2 && r2c2 == r3c1 && r1c3 != "*")
    {
        win = "O";
    }
    else if (r1c1 != "*" && r1c2 != "*" && r1c3 != "*" && r2c1 != "*" && r2c2 != "*" && r2c3 != "*" && r3c1 != "*" && r3c2 != "*" && r3c3 != "*")
    {
        win = "No player";
    }
    #endregion
} while (string.IsNullOrEmpty(win));
Console.WriteLine($" {win} wins!");