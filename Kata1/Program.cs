Console.WriteLine("Welcome, fellow explorer! What is your name?");
string playerName = Console.ReadLine();

Console.WriteLine($"Greetings, {playerName}! Your journey is just getting started.");

Console.WriteLine("On a scale of 1 to 10, how excited do you feel about this new quest?");
            
int excitementLevel;
bool validInput = int.TryParse(Console.ReadLine(), out excitementLevel);

    if (!validInput || excitementLevel < 1 || excitementLevel > 10)
       {
        Console.WriteLine("Please enter a valid excitement level between 1 and 10.");
        }
    else
       {
        if (excitementLevel >= 7)
           {
            Console.WriteLine("Fantastic! You seem ready to face any challenges that might come your way!");
            }
        else
            {
            Console.WriteLine("Uuuf, I can assure you this journey will knock your boots off. Let's work on the excitement a little, mkay?");
            }
       }
        
