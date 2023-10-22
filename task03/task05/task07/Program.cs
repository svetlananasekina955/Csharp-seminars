/*Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.*/

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


int result = number%10;
{ Console.WriteLine(result); }