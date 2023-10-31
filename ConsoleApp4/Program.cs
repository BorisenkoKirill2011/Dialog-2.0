// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

string name;
int first;
int second;
string sign;
int answer;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Введите ваше имя");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
name = Convert.ToString(Console.ReadLine());
Console.ResetColor();
Thread.Sleep(800);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Привет " + name + "!");
Console.ResetColor();
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Привет! Решишь пример? ");
Console.ResetColor();
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Да, конечно. Впишите 1 число");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
first = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Хорошо, теперь введите 2 число");
Console.ResetColor();
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.Red;
second = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Ок, теперь определим знак. Напишите 'Plus' если хотите сложить, либо 'Minus' чтобы вычесть");
Console.ResetColor();
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.Red;
sign = Convert.ToString(Console.ReadLine());
Console.ResetColor();
Thread.Sleep(1000);
if (sign == "Plus")
{
    answer = first + second ;
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Вы выбрали сложение! Ожидайте, произвожу вычисления");
    Thread.Sleep(2000);
    Console.WriteLine("Итак " + name + "!" + " Ваш ответ: " + answer);
    Console.ResetColor();
}
else if (sign == "Minus")
{
    answer = first - second;
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Вы выбрали вычитание! Ожидайте, произвожу вычисления");
    Thread.Sleep(2000);
    Console.WriteLine("Итак " + name + "!" + " Ваш ответ: " + answer);
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Вы выбрали знак которого несуществует, либо его нет в моей базе данных");
    Console.ResetColor();
}




