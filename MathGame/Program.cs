WelcomeUser();
string playerName = GetUserName();

string GetUserName()
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