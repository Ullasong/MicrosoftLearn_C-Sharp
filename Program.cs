Random dice = new Random();

int firstRoll = dice.Next(1, 7);
int secondRoll = dice.Next(1, 7);
int thirdRoll = dice.Next(1, 7);

int total = firstRoll + secondRoll + thirdRoll;

Console.WriteLine($"Dice roll : {firstRoll} {secondRoll} {thirdRoll}");

if (total > 14)
{
    Console.WriteLine("You Win!");
}

if (total < 15)
{
    Console.Write("Sorry, you lose");
}