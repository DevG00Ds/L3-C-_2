// Напишите программу, которая будет принимать на вход 2 числа и выводить, яввляется ли второе число кратным первому.
// Если число 2 не кратно 1, то программа выводит отстаток от деления.

// 34, 5 -> не кратно , остаток 4
// 16, 4 -> кратно, 


Console.WriteLine("Введите число 1: ");
int nam1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int nam2 = Convert.ToInt32(Console.ReadLine());

int res = nam1 % nam2;

if ( res != 0)
{
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Второе число кратно первому");
}
