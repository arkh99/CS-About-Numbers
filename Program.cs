Console.WriteLine("Enter numbers (Press x to exit) : \n");
int num;
int max = int.MinValue;
int min = int.MaxValue;
int numEven = 0;
int numOdd = 0;
int sumEven = 0;
int sumOdd = 0;
int avgEven = 0;
int avgOdd = 0;

while (true)
{
    string? strnum = Console.ReadLine();
    if (strnum == "x" || strnum == "")
    {
        Console.WriteLine("\nEnd! ");
        break;
    }
    bool isValidNum = int.TryParse(strnum, out num);
    if (isValidNum)
    {
        if (num > max)
        {
            max = num;
        }
        if (num < min)
        {
            min = num;
        }

        if (num % 2 == 0)
        {
            numEven++;
            sumEven += num;
        }
        else
        {
            numOdd++;
            sumOdd += num;
        }
    }
    else
    {
        Console.WriteLine("Invalid input, try again.");
    }
}

if (numEven > 0)
{
    avgEven = sumEven / numEven;
}
if (numOdd > 0)
{
    avgOdd = sumOdd / numOdd;
}

Console.WriteLine($"The Max integer you entered is: {max}");
Console.WriteLine($"The Min integer you entered is: {min} \n");

Console.WriteLine($"The number of odd integer(s) you entered is: {numOdd} ");
Console.WriteLine($"The Sum of odd integer(s) you entered is: {sumOdd} ");
Console.WriteLine($"The Avg of odd integer(s) you entered is: {avgOdd} \n");

Console.WriteLine($"The number of even integer(s) you entered is: {numEven} ");
Console.WriteLine($"The Sum of even integer(s) you entered is: {sumEven} ");
Console.WriteLine($"The Avg of even integer(s) you entered is: {avgEven} \n");

Console.WriteLine("End !");
