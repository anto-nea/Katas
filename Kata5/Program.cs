class GameActions
{
    // Method to handle attacking an enemy
    static void AttackEnemy(string enemyName, int damage)
    {
        Console.WriteLine($"Attacked {enemyName} and dealt {damage} damage!");
    }

    // Method to handle healing a player
    static void HealPlayer(string playerName, int healAmount)
    {
        Console.WriteLine($"Player {playerName} healed {healAmount} health points!");
    }

    // Main method to demonstrate both AttackEnemy and HealPlayer methods
    static void Main(string[] args)
    {
        // Call AttackEnemy with example values
        AttackEnemy("Goblin", 20);
        
        // Call HealPlayer with example values
        HealPlayer("Arin", 15);
    }
}