bool tryAgain=false;
do
{
    Console.Write("Please enter the Number: ");
    string? Number = Console.ReadLine();
    bool validNum = int.TryParse(Number, out int ParsedInt);
    if (validNum)
    {
        Console.WriteLine("Number's in Descending order");
        for (int i = ParsedInt; i >= 0; i--)
        {
            Console.WriteLine($"{i}");
        }
        Console.WriteLine("Number's in Ascending order ");
        for (int i = 0; i <= ParsedInt; i++)
        {
            Console.WriteLine($"{i}");
        }
        Console.WriteLine("Would you like to continue (y/n)?");
        string? UserInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(UserInput) && !string.IsNullOrWhiteSpace(UserInput))
        {
            if (UserInput.ToLower() == "y")
                tryAgain = true;
            else
                tryAgain = false;
        }
        else
            break;
    }
    else
    {
        Console.WriteLine("Entered value is not a valid integer: Please try again Later!");
        break;
    }
} while (tryAgain);
    