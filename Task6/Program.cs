// Программа, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int count = 1;
double sum = 0;
while (count <= 5)
{
    int a = Prompt($"Input number{count}: ");
    sum = sum + a;
    count ++;

}


// int a = Prompt("Input the number first: ");
// int b = Prompt("Input the number second: ");
// int c = Prompt("Input the number third: ");
// int d = Prompt("Input the number fourth: ");
// int e = Prompt("Input the number fifth: ");
//int sum = a + b + c + d + e;                          -   вариант решения без цикла.
double average = (sum / (count-1));

Console.WriteLine($"Сумма чисел: = {sum}");
Console.WriteLine($"Cреднее арифметическое число: = {average}");


