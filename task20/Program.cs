// 20. Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

Console.WriteLine("Задайте координаты A x");
int userAX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте координаты A y");
int userAY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте координаты B x");
int userBX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте координаты B y");
int userBY = Convert.ToInt32(Console.ReadLine());
// int sqrX = (userBX - userAX) * (userBX - userAX)
double sqrX = Math.Pow(userBX - userAX, 2); //возводит в степень
double sqrY = Math.Pow(userBY - userAY, 2);
double sqrt = Math.Sqrt(sqrX + sqrY);// выводит квадратный корень
Console.WriteLine(Math.Round(sqrt, 2));//округляет десятичное число