﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. (номер цифры считается от левого края)

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine(" Введите число от 100");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine(" Error");
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    Console.WriteLine(number % 10);
}