// Программа, которая принимает н вход трехзначное число и на выходе показывает последнюю цифру, этого числа.
//456->6
//782->2
//918->8

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


int number = Prompt("Enter a three-digit number: ");
if (ValidateNumber(number))
{
    int lastDigit = number % 10;
    Console.WriteLine($"The last digit of the number{number} is equal to {lastDigit}");
}




