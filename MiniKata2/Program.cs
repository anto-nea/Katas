string characterName = "Arin";
int healthPoints = 100;
float attackPower = 30.5f;
float experiencePoints = 250.75f;
bool isParalyzed = false;
double currencyAmount = 75.50;

double healthAsDouble = healthPoints; 
Console.WriteLine($"Health as double (implicit conversion): {healthAsDouble}");

int attackPowerAsInt = (int)attackPower; 
Console.WriteLine($"Attack Power as int (explicit conversion): {attackPowerAsInt}");

int experienceAsInt = Convert.ToInt32(experiencePoints); 
Console.WriteLine($"Experience as int (using Convert): {experienceAsInt}");

string currencyString = "150.3333333";
double parsedCurrency;

    if (double.TryParse(currencyString, out parsedCurrency))
    {
    Console.WriteLine($"Gold Coins (parsed from string): {parsedCurrency}");
    }
    else
    {
    Console.WriteLine("Parsing failed: Invalid currency value.");
    }

string invalidString = characterName;
    if (int.TryParse(invalidString, out int parsedInt))
    {
    Console.WriteLine($"Parsing succeeded: {parsedInt}");
    }
    else
    {
    Console.WriteLine($"Parsing failed: '{invalidString}' is not a number.");
    }

Console.WriteLine("\nOriginal Values:");
Console.WriteLine($"Character Name: {characterName}");
Console.WriteLine($"Health Points: {healthPoints}");
Console.WriteLine($"Attack Power: {attackPower}");
Console.WriteLine($"Experience Points: {experiencePoints}");
Console.WriteLine($"Is Paralyzed: {isParalyzed}");
Console.WriteLine($"Currency Amount: {currencyAmount}");
