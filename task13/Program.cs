// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другова 

// 5,24 -> ДА 
// -4,16 -> ДА
// 25,5 -> ДА
// 8,9 -> НЕТ


Console.WriteLine(" Введите первое число : ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Введите второе число : ");
int number2 = Convert.ToInt32(Console.ReadLine());

if ( number1 == number2*number2 || number2 == number1*number1)
{
    Console.WriteLine(" Одно число является квадратом другого");
}
else
{
    Console.WriteLine(" Не является квадратом другого");
}