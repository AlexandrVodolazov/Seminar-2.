// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int number = Prompt("Enter the number from 1 to 7, corresponding to the day of the week: ");
if (ValidateNumber(number))
{
    if (number >= 1 && number < 6)
    {
        Console.WriteLine($"{number}: is not a holiday");
    }
    else
    {
        Console.WriteLine($"{number}: is a holiday");
    }
}


bool ValidateNumber(int number)
{
    if (number < 1 || number > 7)
    {
        Console.WriteLine("the number entered does not match the day of the week!!!");
        return false;
    }
    return true;
}

