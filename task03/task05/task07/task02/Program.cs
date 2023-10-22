/* 2.Напишите программу, которая на вход принимает два числа и выдает какое большее, а какое меньшее.*/
Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(number1 > number2)
 max = number1;
 if( number2 > number1)
 max = number2;
{Console.WriteLine($"max = {max}"); }
