// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное числo - ");
string input = Console.ReadLine();
int num = Convert.ToInt32(input);

if (num > 100 && num <1000)
{
    int num1 = num % 10;
    int num2 = ((num-num1) %100)/10;  
    Console.WriteLine (num2);
}
    else Console.WriteLine("Вы ввели неправильное значение числа!");