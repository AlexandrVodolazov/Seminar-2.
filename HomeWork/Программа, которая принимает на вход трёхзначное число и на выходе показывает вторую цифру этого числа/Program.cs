// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number <= 100 || number >= 1000)
    {
        Console.WriteLine("This number is not three digits");
        return false;
    }
    return true;
}

int number = Prompt("Enter a three-digit: ");

if (ValidateNumber(number))
{
    int FirstDigit = number / 10;
    int SecondDigit = FirstDigit % 10;
    Console.WriteLine($"the second digit of the number: {number} is equal to: {SecondDigit}");
}



