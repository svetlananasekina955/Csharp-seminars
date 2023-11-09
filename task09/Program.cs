// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает 
//наибольшую цифру числа.
int n  = new Random().Next(10,99);
Console.WriteLine(n);
int max = 0;
do max =Math.Max(max,n%10);
while((n/=10)!=0);


Console.WriteLine(max);