// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите числo, обозначающее день недели - ");
string input = Console.ReadLine();
int num = Convert.ToInt32(input);

if (num > 5 && num <8)
{
   Console.WriteLine ("Этот день является выходным.");
}

if (num > 0 && num < 6)
{   
    Console.WriteLine ("Этот день не является выходным.");
}

if (num < 1 || num > 7)
{
    Console.WriteLine ("Это какой-то неправильный день недели...");
}