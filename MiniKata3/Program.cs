int playerLuck = 7; 

Console.WriteLine("You encounter an enemy! Do you want to attempt an attack? (yes/no)");
string choice = Console.ReadLine().ToLower().Trim();

    if (choice == "yes")
        {
        Console.WriteLine("Attempting to attack...");
        Console.WriteLine(playerLuck > 7 ? "Success! Your attack hits the enemy."
                        : playerLuck >= 7 ? "Your attack barely succeeded!"
                        : "Your attack missed the enemy.");
        }
    
    else if (choice == "no")
        {
        Console.WriteLine("You retreated.");
        }
    else
        {
        Console.WriteLine("Invalid choice.");
        }

