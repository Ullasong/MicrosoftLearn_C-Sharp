Random dice = new Random();

int roll01 = dice.Next(1, 7);
int roll02 = dice.Next(1, 7);
int roll03 = dice.Next(1, 7);

int total = roll01 + roll02 + roll03;

Console.WriteLine($"Dice roll : {roll01} + {roll02} + {roll03} = {total}");

if ((roll01 == roll02) || (roll02 == roll03) || (roll03 == roll01))
{
    if ((roll01 == roll02) && (roll02 == roll03))
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 2;
    }
}

total = 7;
Console.WriteLine(total);

if (total >= 16) Console.WriteLine("car");
else if (total >= 10) Console.WriteLine("laptop");
else if (total == 7) Console.WriteLine("ticket");
else Console.WriteLine("kitten");
//else는 if와 else if 모두 해당되지 않을 때 실행 되며,
//선택 사항이지만 마지막에 와야 함.