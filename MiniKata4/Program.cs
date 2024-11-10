Console.WriteLine("Spawning enemies using a for loop:");
    int numberOfEnemiesForLoop = 5;

    for (int i = 1; i <= numberOfEnemiesForLoop; i++)
        {
            Console.WriteLine($"Enemy #{i} spawned!");
        }

Console.WriteLine("\nSpawning enemies using a while loop:");
    int numberOfEnemiesWhileLoop = 3;
    int count = 1;

    while (count <= numberOfEnemiesWhileLoop)
        {
            Console.WriteLine($"Enemy #{count} spawned!");
        count++;
        }