int playerHealth = 80;
int playerAttackPower = 15;
int enemyHealth = 50;
int enemyAttackPower = 10;

while (playerHealth > 0 && enemyHealth > 0)
{
//health of both players
    Console.WriteLine($"Hero's Health: {playerHealth}");
    Console.WriteLine($"Goblin's Health: {enemyHealth}");

    Console.WriteLine("Choose an action:");
    Console.WriteLine("1. Attack");
    Console.WriteLine("2. Heal");
    Console.Write("> ");
    string choice = Console.ReadLine();

//attack
   if (choice == "1") 
    {
        Console.WriteLine("Hero attacks the Goblin!");
        enemyHealth -= playerAttackPower;
        Console.WriteLine($"Goblin takes {playerAttackPower} damage.");
    }
    else if (choice == "2") 
    {
        int healAmount = 10; 
        playerHealth += healAmount;
        Console.WriteLine($"Hero heals for {healAmount} health.");
    }
    else
    {
        Console.WriteLine("Invalid choice, try again.");
        continue;
    }
   
//enemy attack (if alive)
    if (enemyHealth > 0)
    {
        Console.WriteLine("Goblin attacks Hero!");
        playerHealth -= enemyAttackPower;
        Console.WriteLine($"Hero takes {enemyAttackPower} damage.");
    }
    
// game over conditions
    if (playerHealth <= 0)
    {
        Console.WriteLine("Game Over! Hero has been defeated.");
        break;
    }
    else if (enemyHealth <= 0)
    {
        Console.WriteLine("Congratulations! Hero has defeated the Goblin!");
        break;
    }
}