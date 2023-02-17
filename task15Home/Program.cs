// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine(" Введите цифру обозначающию день недели");
int daynumber = Convert.ToInt32(Console.ReadLine());


if (daynumber >= 1 && daynumber <= 7)
{
    if (daynumber >= 6)
    {
        Console.WriteLine("Этот день недели выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}
else
{
        Console.WriteLine(" Это не цифра дня недели ");
}
