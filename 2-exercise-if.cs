Random roll = new Random();

int first = roll.Next(1, 7); //int의 max값은 +1
int second = roll.Next(1, 7);
int third = roll.Next(1, 7);

int total = first + second + third;
Console.WriteLine($"first : {first}\tsecod : {second}\tthird : {third}\t\ttotal : {total}");

if ((first == second) || (second == third) || (third == first))
{
    total += 2;
    Console.WriteLine("It's Double rolling!! you got a two Bonus");
}

if (((first == second) && (second == third)) || ((second == third) && (third == first)) || ((third == first) && (first == second)))
{
    total += 6;
    Console.WriteLine("It's Triple rolling!! you got a six Bonus");
}

if (total >= 15) { Console.WriteLine("\nCongratulation You Win!!"); }
else { Console.WriteLine("\nSorry, You Lose"); }