using MathGameLibrary;

WelcomeUser();

PlayerModel player = new();
player.PlayerName = GetUserName();

bool play = true;
while (play)
{
    Operator operation = GetOperatorChoice();
    PlayRound(operation, player);

    string choice = GetMenuChoice();
    if (choice == "h")
    {
        DisplayHistory(player);
        choice = GetMenuChoice();
    }
    else if (choice == "n")
    {
        play = false;
        Console.WriteLine("Thanks for playing!");
        Console.ReadLine();
    }
}

void DisplayHistory(PlayerModel player)
{
    throw new NotImplementedException();
}

string GetMenuChoice()
{
    throw new NotImplementedException();
}

void PlayRound(Operator choice, PlayerModel player)
{
    throw new NotImplementedException();
}

bool KeepPlaying()
{
    throw new NotImplementedException();
}

Operator GetOperatorChoice()
{
    throw new NotImplementedException();
}

static string GetUserName()
{
    string? name;
    do
    {
        Console.Write("Please enter your name: ");
        name = Console.ReadLine()!;
    } while (name == string.Empty);
    return name;
}

static void WelcomeUser()
{
    Console.WriteLine("Welcome to Math Quizzer!");
    Console.WriteLine();
    Console.WriteLine("Created by Corey Jordan, 2023");
    Console.WriteLine("Designed for The C# Academy \"Math Game\"");
    Console.WriteLine();
}