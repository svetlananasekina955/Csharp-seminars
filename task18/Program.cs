﻿// 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());
    if(number == 1)
    { Console.WriteLine("X > 0 и Y > 0"); }
      if(number == 2)
{ Console.WriteLine("X < 0 и Y > 0");     }  
    if(number == 3)
    { Console.WriteLine("X < 0 и Y < 0");    }
    if(number == 4)
    { Console.WriteLine("X > 0 и Y < 0"); }
     if(number < 1 || number > 4)
     { Console.WriteLine("Нет такой четверти"); }