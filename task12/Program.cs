// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23 

// 14 -> Нет 
// 46 -> Нет 
// 161 -> ДА 


Console.WriteLine(" Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine(" ДА");
}
else
{
    Console.WriteLine(" НЕТ ");
}