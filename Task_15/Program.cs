// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

if(number < 1 || number > 7)
{
Console.WriteLine("Это число не соответствует дню недели");
}
else
    if(number < 8 && number > 5)
    {
    Console.WriteLine("Этот день выходной");
    }
    else
    {
        Console.WriteLine("Этот день рабочий");
    }