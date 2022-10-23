// Программа, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78->8
//12->2
//85->8

int number = new Random().Next(10, 100);

int FirstDigit = number / 10;
int LastDigit = number % 10;

if (FirstDigit > LastDigit)
{
    Console.WriteLine($"The Firest digit of the number {number} is greater to {LastDigit}");
}
else
{
    Console.WriteLine($"The Last digit of the number {number} is greater to {FirstDigit}");
}




