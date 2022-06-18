// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите числo - ");
string input = Console.ReadLine();
int a = input.Length;

if (a <= 2)
{
    Console.WriteLine ("Вы ввели неправильное число!");
}    
    else Console.WriteLine (input[2]);
