using System;

string playerName = "";
int score = 0;
int roundsPlayed = 0;
List<string> myIngredients = new List<string>();

Console.Clear();
Console.WriteLine("╔═════════════════════════════════════════════════╗");
Console.WriteLine("║           FILIPINO DISH COOKING GAME            ║");
Console.WriteLine("║         Learn to cook Filipino dishes!          ║");
Console.WriteLine("╚═════════════════════════════════════════════════╝");
Console.WriteLine("             by: JOHN IVAN L. MOSTOLES       ");
Console.WriteLine("                 21 - CPE - 01              ");
Console.WriteLine();


while (true)
{
    Console.WriteLine("     ┌─────────────────────────────────┐");
    Console.WriteLine("     │          MAIN MENU              │");
    Console.WriteLine("     ├─────────────────────────────────┤");
    Console.WriteLine("     │       1 - Start Play            │");
    Console.WriteLine("     │       2 - How to Play           │");
    Console.WriteLine("     │       3 - Quit Game             │");
    Console.WriteLine("     └─────────────────────────────────┘");
    Console.Write("Pick a number: ");

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        StartGame();
    }
    else if (choice == "2")
    {
        ShowHowToPlay();
    }
    else if (choice == "3")
    {
        Console.Clear();
        Console.WriteLine("╔══════════════════════════════════════╗");
        Console.WriteLine("║         Matsala for paglaro!         ║");
        Console.WriteLine("║           Bounce na akes!            ║");
        Console.WriteLine("╚══════════════════════════════════════╝");
        break; 
    }
    else
    {
        Console.WriteLine("❌ Please pick 1, 2, or 3!");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        Console.Clear();
    }
}

void StartGame()
{
    Console.Clear();
    Console.WriteLine("╔═════════════════════════════════╗");
    Console.WriteLine("║             NEW GAME            ║");
    Console.WriteLine("╚═════════════════════════════════╝");
    Console.WriteLine("      Welcome sa Kusina Gar   ");
    Console.WriteLine();
    Console.Write("Ano magiging tawag namin sayo, Chef? ");
    playerName = Console.ReadLine();

    if (playerName == "")
    {
        playerName = "Chef";
    }

    score = 0;
    roundsPlayed = 0;

    Console.WriteLine();
    Console.WriteLine("Hi Chef " + playerName + "! Let's start cooking! 🍳");
    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();

    PlayOneRound();
}


void PlayOneRound()
{
    roundsPlayed = roundsPlayed + 1;
    myIngredients.Clear(); 

    Console.Clear();
    Console.WriteLine("╔══════════════════════════════════=════╗");
    Console.WriteLine("║                ROUND " + roundsPlayed + "                ║");
    Console.WriteLine("╚═══════════════════════════════════════╝");
    Console.WriteLine(" Player: " + playerName);
    Console.WriteLine(" Score: " + score);
    Console.WriteLine();
    Console.WriteLine("         Tara na gar bili tayo ingredients!   ");
    Console.WriteLine();
    Console.WriteLine("Press Enter to go to the market...");
    Console.ReadLine();

    PickIngredients();
}

void PickIngredients()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("╔════════════════════════════════════════╗");
        Console.WriteLine("║             Palengke ni Gar            ║");
        Console.WriteLine("╚════════════════════════════════════════╝");
        Console.WriteLine("    PILI KA LANG GAR         ");
        Console.WriteLine();

        if (myIngredients.Count > 0)
        {
            Console.Write("You have: ");
            for (int i = 0; i < myIngredients.Count; i++)
            {
                Console.Write(myIngredients[i]);
                if (i < myIngredients.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Wala ka bibilihin?");
        }

        Console.WriteLine();
        Console.WriteLine("┌────────────────────────────┐");
        Console.WriteLine("│     Pick an ingredient:    │");
        Console.WriteLine("├────────────────────────────┤");
        Console.WriteLine("│  1 -  Pork                 │");
        Console.WriteLine("│  2 -  Beef                 │");
        Console.WriteLine("│  3 -  Potato               │");
        Console.WriteLine("│  4 -  Carrot               │");
        Console.WriteLine("│  5 -  Tomato Sauce         │");
        Console.WriteLine("│  6 -  Onion                │");
        Console.WriteLine("│  7 -  Garlic               │");
        Console.WriteLine("│  8 -  Liver                │");
        Console.WriteLine("│  9 -  Hotdog               │");
        Console.WriteLine("│ 10 -  Cheese               │");
        Console.WriteLine("│ 11 -  Soy Sauce            │");
        Console.WriteLine("│ 12 -  Lemon                │");
        Console.WriteLine("├────────────────────────────┤");
        Console.WriteLine("│  0 -  Done (need 3+)       │");
        Console.WriteLine("└────────────────────────────┘");
        Console.Write("Your choice: ");

        string choice = Console.ReadLine();

        if (choice == "0")
        {
            if (myIngredients.Count >= 3)
            {
                break;
            }
            else
            {
                Console.WriteLine(" Need mo atleast 3 para makaluto gar!");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
        else if (choice == "1")
        {
            AddIngredient("pork");
        }
        else if (choice == "2")
        {
            AddIngredient("beef");
        }
        else if (choice == "3")
        {
            AddIngredient("potato");
        }
        else if (choice == "4")
        {
            AddIngredient("carrot");
        }
        else if (choice == "5")
        {
            AddIngredient("tomato sauce");
        }
        else if (choice == "6")
        {
            AddIngredient("onion");
        }
        else if (choice == "7")
        {
            AddIngredient("garlic");
        }
        else if (choice == "8")
        {
            AddIngredient("liver");
        }
        else if (choice == "9")
        {
            AddIngredient("hotdog");
        }
        else if (choice == "10")
        {
            AddIngredient("cheese");
        }
        else if (choice == "11")
        {
            AddIngredient("soy sauce");
        }
        else if (choice == "12")
        {
            AddIngredient("lemon");
        }
        else
        {
            Console.WriteLine("Please pick a number from the list!");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    GuessTheDish();
}


void AddIngredient(string ingredient)
{
    bool alreadyHave = false;
    for (int i = 0; i < myIngredients.Count; i++)
    {
        if (myIngredients[i] == ingredient)
        {
            alreadyHave = true;
            break;
        }
    }

    if (alreadyHave)
    {
        Console.WriteLine("You already have " + ingredient + "!");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
    else
    {
        myIngredients.Add(ingredient);
        Console.WriteLine("Added " + ingredient + " to your dish!");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}

void GuessTheDish()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════╗");
    Console.WriteLine("║               KUSINA NI GAR            ║");
    Console.WriteLine("╚════════════════════════════════════════╝");
    Console.WriteLine("        *sizzle* *sizzle* ");
    Console.WriteLine();
    Console.WriteLine("Magluluto ka gamit ang mga ingredients na ito:");
    for (int i = 0; i < myIngredients.Count; i++)
    {
        Console.WriteLine("    " + myIngredients[i]);
    }

    Console.WriteLine();
    Console.WriteLine("┌──────────────────────────────────────────┐");
    Console.WriteLine("│      What Filipino dish did you make?    │");
    Console.WriteLine("├──────────────────────────────────────────┤");
    Console.WriteLine("│             1 -  Afritada                │");
    Console.WriteLine("│             2 -  Menudo                  │");
    Console.WriteLine("│             3 -  Kaldereta               │");
    Console.WriteLine("│             4 -  Mechado                 │");
    Console.WriteLine("└──────────────────────────────────────────┘");
    Console.Write("Your guess: ");

    string guess = Console.ReadLine();

    Random random = new Random();
    int correctAnswer = random.Next(1, 5); 

    Console.Clear();
    if (guess == correctAnswer.ToString())
    {
        Console.WriteLine("╔═════════════════════════════════════════════╗");
        Console.WriteLine("║               TAMA KA DIYAN!                ║");
        Console.WriteLine("║          + aura points ka saakin!           ║");
        Console.WriteLine("╚═════════════════════════════════════════════╝");
        Console.WriteLine("         +100 AURA POINTS!");
        score = score + 100;
    }
    else
    {
        Console.WriteLine("╔═════════════════════════════════════════════════╗");
        Console.WriteLine("║                  MALI GAGI!                     ║");
        Console.WriteLine("║             Minus aura points ka!               ║");
        Console.WriteLine("╚═════════════════════════════════════════════════╝");
        Console.WriteLine("Ang niluto mo ay: " + correctAnswer);
        ShowCorrectDish(correctAnswer);
    }

    Console.WriteLine();
    Console.WriteLine("⭐ Your total score: " + score + " ⭐");
    Console.WriteLine();
    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();

    AskPlayAgain();
}

void ShowCorrectDish(int dishNumber)
{
    if (dishNumber == 1)
    {
        Console.WriteLine("Afritada is a Filipino pork stew with tomato sauce and vegetables.");
    }
    else if (dishNumber == 2)
    {
        Console.WriteLine("Menudo is a Filipino dish with pork, liver, and hotdog pieces.");
    }
    else if (dishNumber == 3)
    {
        Console.WriteLine("Kaldereta is a Filipino beef stew often made with cheese.");
    }
    else if (dishNumber == 4)
    {
        Console.WriteLine("Mechado is a Filipino beef dish cooked with soy sauce and lemon.");
    }
}

void AskPlayAgain()
{
    Console.Clear();
    Console.WriteLine("╔═════════════════════════════════╗");
    Console.WriteLine("║        What's next?             ║");
    Console.WriteLine("╠═════════════════════════════════╣");
    Console.WriteLine("║ 1 -  ISA PA                     ║");
    Console.WriteLine("║ 2 -  Or suko na (aray ko)       ║");
    Console.WriteLine("╚═════════════════════════════════╝");
    Console.Write("Your choice: ");

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        PlayOneRound();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("🔄 Going back to main menu...");
        Console.WriteLine();
    }
}

void ShowHowToPlay()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════╗");
    Console.WriteLine("║             HOW TO PLAY                ║");
    Console.WriteLine("╚════════════════════════════════════════╝");
    Console.WriteLine();
    Console.WriteLine(" GAME RULES:");
    Console.WriteLine("   1. Pick ingredients from the Market ");
    Console.WriteLine("   2. You need at least 3 ingredients ");
    Console.WriteLine("   3. Guess what Filipino dish you made ");
    Console.WriteLine("   4. Get points for correct guesses! ");
    Console.WriteLine();
    Console.WriteLine(" FILIPINO DISHES in this game:");
    Console.WriteLine("   Afritada: Pork stew with tomato sauce");
    Console.WriteLine("   Menudo: Pork with liver and hotdog");
    Console.WriteLine("   Kaldereta: Beef stew with cheese");
    Console.WriteLine("   Mechado: Beef dish with soy sauce");
    Console.WriteLine();
    Console.WriteLine(" SCORING: 100 points per correct answer!");
    Console.WriteLine();
    Console.WriteLine("Press Enter to go back...");
    Console.ReadLine();
    Console.Clear();
}