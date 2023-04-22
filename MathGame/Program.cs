using MathGameLibrary;

WelcomeUser();

PlayerModel player = new()
{
    PlayerName = GetUserName()
};

// Main program
bool play = true;
while (play)
{
    Operator operation = GetOperatorChoice(player);
    PlayRound(operation, player);

    string choice = GetMenuChoice();
    if (choice == "H")
    {
        DisplayHistory(player);
        choice = GetMenuChoice();
        if (choice == "Q")
        {
            play = EndGame();
        }
    }
    else if (choice == "Q")
    {
        play = EndGame();
    }
}

void DisplayHistory(PlayerModel player)
{
    double overall = 0.0;
    foreach (GameModel game in player.GameHistory)
    {
        overall += game.PercentCorrect;
        Console.Write($"Game {player.GameHistory.IndexOf(game) + 1}  {game.Operation} ");
        Console.WriteLine($"{game.CorrectAnswers} correct, {game.PercentCorrect}%");
        Console.WriteLine();
    }
    double score = overall / player.GameHistory.Count;
    Console.WriteLine($"Total score: {score:n0}%");
    Console.WriteLine();
}

string GetMenuChoice()
{
    string choice;
    do
    {
        Console.WriteLine("Select an option:");
        Console.Write("P: Play again, Q: Quit, H: Game History ");
        choice = Console.ReadLine()!.ToUpper();
        if (choice != "P" && choice != "Q" && choice != "H")
        {
            Console.Write("Please choose again. ");
        }
    } while (choice != "P" && choice != "Q" && choice != "H");
    Console.WriteLine();
    return choice;
}

void PlayRound(Operator mode, PlayerModel player)
{
    GameModel round = new();

    for (int i = 0; i < round.NumberOfQuestions; i++)
    {
        int number1 = GameLogic.GetRandomNumber();
        int number2 = GameLogic.GetRandomNumber();
        char symbol = GetSymbol(mode);

        Console.Write($"{number1} {symbol} {number2} = ");
        int userGuess = GetUserGuess();

        int correctAnswer = GameLogic.Solution(number1, number2, mode);
        bool isCorrect = GameLogic.CheckGuess(correctAnswer, userGuess);

        if (isCorrect)
        {
            Console.WriteLine("Correct!");
            round.CorrectAnswers++;
        }
        else 
        {
            Console.WriteLine($"Sorry, the correct answer is {correctAnswer}");
        }
    }
    player.GameHistory.Add(round);
    Console.WriteLine("Round Results");
    Console.WriteLine($"{round.CorrectAnswers} out of {round.NumberOfQuestions} correct: {round.PercentCorrect}%");
    Console.Write("Press enter to continue...");
    Console.ReadLine();
    Console.Clear();
    }

char GetSymbol(Operator mode)
{
    return mode switch
    {
        Operator.Add => '+',
        Operator.Subtract => '-',
        Operator.Multiply => 'x',
        Operator.Divide => '/',
        _ => '+',
    };
}

int GetUserGuess()
{
    int userGuess;
    bool isValid;
    do
    {
        isValid = int.TryParse(Console.ReadLine(), out userGuess);
        if (!isValid)
        {
            Console.WriteLine("Invalid guess, please try again.");
        }
    } while (!isValid);
    return userGuess;
}

Operator GetOperatorChoice(PlayerModel player)
{
    string userInput;
    do
    {
    Console.WriteLine($"{player.PlayerName}, Select an operation");
    Console.Write($"1: {Operator.Add}, 2: {Operator.Subtract}, 3: {Operator.Multiply}, 4: {Operator.Divide} ");

    userInput = Console.ReadLine()!;
    } while (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4");


    return userInput switch
    {
        "1" => Operator.Add,
        "2" => Operator.Subtract,
        "3" => Operator.Multiply,
        _ => Operator.Divide,
    };
}

static string GetUserName()
{
    string? name;
    do
    {
        Console.Write("Please enter your name: ");
        name = Console.ReadLine()!;
    } while (name == string.Empty);
    Console.WriteLine();
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

static bool EndGame()
{
    bool play = false;
    Console.WriteLine("Thanks for playing!");
    Console.ReadLine();
    return play;
}