int totalWaves = 3;
int enemiesPerWave = 4;

for (int wave = 1; wave <= totalWaves; wave++)
{
    Console.WriteLine($"Wave {wave} is starting!");

//loop to spawn enemies in the 1st wave 
for (int enemy = 1; enemy <= enemiesPerWave; enemy++)
    {
        Console.WriteLine($"  Enemy #{enemy} has spawned.");
    }

//following waves
    Console.WriteLine($"Wave {wave} completed. Preparing for the next wave...\n");

//pause to mimic a delay between the waves
System.Threading.Thread.Sleep(1000); 
}

Console.WriteLine("All waves completed! Victory is yours!");