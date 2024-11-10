string characterName = "Lira";
int level = 5;
float healthPoints = 75.5f;
double experiencePoints = 1025.75;
bool hasMagicAbility = true;
char rank = 'A';

double nextLevelThreshold = 1200.0;

double pointsToNextLevel = nextLevelThreshold - experiencePoints;

Console.WriteLine($"Character Name: {characterName}");
Console.WriteLine($"Level: {level}");
Console.WriteLine($"Health Points: {healthPoints}");
Console.WriteLine($"Experience Points: {experiencePoints}");
Console.WriteLine($"Has Magic Ability: {hasMagicAbility}");
Console.WriteLine($"Rank: {rank}");
Console.WriteLine($"Points needed to reach next level: {pointsToNextLevel}");