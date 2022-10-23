// Программа, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно , остаток 4.
// 16, 4 -> кратно.


int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int DivBy(int A, int B) // вычисляем остаток от деления В на А(2 / 4 = 0 целых и 2 в остатке)
{
    return(B % A);
}

int A = Prompt("Enter first number: ");
int B = Prompt("Enter second number: ");

if (DivBy(A, B) == 0)
{
    Console.WriteLine("number {int A}, is a multiple {int B}");
}

else
{
    Console.WriteLine(DivBy(A, B));
}

