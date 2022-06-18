// Доп. задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Введите первое числo - ");
string input1 = Console.ReadLine();
int num1 = Convert.ToInt32(input1);

Console.WriteLine("Введите второе числo - ");
string input2 = Console.ReadLine();
int num2 = Convert.ToInt32(input2);

if (num1 == num2*num2)
{
    Console.WriteLine("число " + num1 + " является квадратом числа " + num2);
}

if (num2 == num1*num1)
{
    Console.WriteLine("число " + num2 + " является квадратом числа " + num1);
}

if (num1 != num2*num2 && num2 != num1*num1)
{
    Console.WriteLine("Ни одно из данных чисел не является квадратом другого.");
}