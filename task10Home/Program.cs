// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine(" Введите трехзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number > 100)
{
    int a = number / 100;
    int b = (number / 10) % 10;
    int c = number % 10;
    Console.WriteLine(b);
}
else
{
    Console.WriteLine(" Число не трехзначное");
}