// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6


int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


bool ValidateNumber(int number)
{
    if (number <= 100)
    {
        Console.WriteLine("This number is no third digit");
        return false;
    }
    return true;
}

int number = Prompt("Enter the number: ");

if (ValidateNumber(number))
{
    while (number > 1000)
    {
        number = number / 10;
    }
    int thirdDigit = number % 10;
    
    Console.WriteLine($"third digit of the number {number} to equlas {thirdDigit}");
}



