// Напишите прогрумму которая выводит случайное трехзначное число и удаляет вторую чуфру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int num = Random.Shared.Next(100, 1000);
Console.WriteLine(num);

int last2 = num % 10;
int last = num / 100;
int res = last2*10 + last;

Console.WriteLine(res);




