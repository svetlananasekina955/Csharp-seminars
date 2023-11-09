// 16.Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number2 == number1 * number1 || number1 == number2 * number2)
Console.WriteLine("да");
else
Console.WriteLine("нет");

