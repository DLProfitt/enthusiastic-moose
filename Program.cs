using System;

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

}

Main();

void MooseSays(string message)
{
    Console.WriteLine(@"

                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |   
                      / `^`   `^` \
                     /             \
                    |      '._.'    \
                    |     /         \
                     \   /|           \
                      |  \ \    _    _ \
                      /|  \ \  (_\  /_)/
                      \ \ //'._  ` '_.'
                       `^^`     `^^^`
    ");

    Console.WriteLine(message);

    Console.WriteLine("I really am enthusiastic");

}

MooseSays("H I,  I ' M  E N T H U S I A S T I C !");

void MooseReplies(string message)
{
    Console.WriteLine(@"
 ___             ____
{   \           /    }
{__  \_       _/  __/
  _\   /     \   /__
 {___  \_____/   ___}
     \_  ~~ ~~  /
       |(o} (o}  \_
       | ^   ^  
     _/          __
    /o)  (o) {   }
    |_      _|\_/
    [_______],
      \\___//
       ^^^^^
    ");

    Console.WriteLine(message);
}


bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine();
    if (answer == null)
    {
        answer = "";
    }
    answer = answer.ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine();
        if (answer == null)
        {
            answer = "";
        }
        answer = answer.ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

void CanadaQuestion()
{
    bool isTrue = MooseAsks("Is Canada real?");
    if (isTrue)
    {
        MooseReplies("Really? It seems very unlikely.");
    }
    else
    {
        MooseReplies("I  K N E W  I T !!!");
    }
}

CanadaQuestion();

void EnthusiasticQuestion()
{
    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    if (isEnthusiastic)
    {
        MooseSays("Yay!");
    }
    else
    {
        MooseSays("You should try it!");
    }
}

EnthusiasticQuestion();

void LoveCSharpQuestion()
{
    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    if (doesLoveCSharp)
    {
        MooseReplies("Good job sucking up to your instructor!");
    }
    else
    {
        MooseReplies("You will...oh, yes, you will...");
    }
}

LoveCSharpQuestion();

void SecretQuestion()
{
    bool wantsSecret = MooseAsks("Do you want to know a secret?");
    if (wantsSecret)
    {
        MooseReplies("ME TOO!!!! I love secrets...tell me one!");
    }
    else
    {
        MooseReplies("Oh, no...secrets are the best, I love to share them!");
    }
}

SecretQuestion();