class Game
{
    static void Main(string[] args)
    {
        //array enemy anmes
        string[] enemies = { "Goblin", "Orc", "Troll", "Skeleton", "Dragon" };
        Console.WriteLine("Enemies:");
        foreach (string enemy in enemies)
        {
            Console.WriteLine(enemy);
        }

        // list of inventory items
        var inventory = new List<string> { "Sword", "Shield", "Potion" };
        Console.WriteLine("\nPlayer Inventory:");
        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }

        // add items
        inventory.Add("Helmet");
        inventory.Add("Armor");

        // remove item
        inventory.Remove("Potion");

        // update list
        Console.WriteLine("\nUpdated Inventory:");
        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }

        // display no. total items
        Console.WriteLine("\nTotal Items in Inventory: " + inventory.Count);
    }
}