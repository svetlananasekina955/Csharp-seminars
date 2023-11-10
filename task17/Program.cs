// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("задайте координаты X: ");
int userX = int.Parse(Console.ReadLine());
Console.Write("задайте координаты Y: ");
int userY = int.Parse(Console.ReadLine());
   if(userX > 0 && userY > 0)
{ Console.WriteLine("точка находится в 1 четверти"); }
   if(userX < 0 && userY > 0)
{ Console.WriteLine("точка находится в 2 четверти"); }
   if(userX < 0 && userY < 0)
{ Console.WriteLine("точка находится в 3 четверти"); }
   if(userX > 0 && userY < 0)
  { Console.WriteLine("точка находится в 4 четверти"); }
  if(userX == 0 || userY == 0)
  { 
    Console.WriteLine("точка находиться на оси координат");
  }