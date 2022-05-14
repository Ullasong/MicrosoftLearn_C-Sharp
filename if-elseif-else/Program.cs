// See https://aka.ms/new-console-template for more information
Random dice = new Random();
int firstRoll = dice.Next(1, 7);
int secondRoll = dice.Next(1, 7);
int thirdRoll = dice.Next(1, 7);
int total = firstRoll + secondRoll + thirdRoll;

if ((firstRoll == secondRoll) || (secondRoll == thirdRoll) || (thirdRoll == firstRoll))
{
    total += 2;
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
}
if((firstRoll == secondRoll && secondRoll == thirdRoll && thirdRoll == firstRoll))
{
    total += 6;
    Console.WriteLine("You rolled triple! +6 bonus to total!");
}
if (total >= 15)
{
  Console.WriteLine("You Win");
}
else
{
    Console.WriteLine("You Lose");
} 
