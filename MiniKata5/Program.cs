class GameActions
{
//attack
static void Attack(int damage)
    {
        Console.WriteLine($"Player dealt {damage} damage!");
    }

//healing
    static void Heal(int healAmount)
    {
        Console.WriteLine($"Player healed {healAmount} health points!");
    }

//both
    static void Main(string[] args)
    {
        Attack(15);
        Heal(10);
    }
}
