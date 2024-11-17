class Game
{
    static void Main(string[] args)
    {
    //arrays for enemies
        string[] enemies = { "Goblin", "Orc", "Troll" };
        Print("Enemies:");
        foreach (string enemy in enemies)
            {
            Print(enemy);
            }
    
    // list of inventory
        var inventory = new List<string> { "Sword", "Shield", "Potion" };
        Print("\nPlayer Inventory:");
        foreach (string item in inventory)
            {
            Print(item);
            }
    
    //add another item on list + display
        inventory.Add("Helmet");
        Print("\nUpdated Inventory:");
        foreach (string item in inventory)
            {
            Print(item);
            }
    }

static void Print(string message)
    {
    Console.WriteLine(message);
    }
}


