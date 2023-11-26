// 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму 
//отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных
// равна -20.
int[] GetRnd(int size)
{
int[] array = new int[size];

 for(int i = 0; i < size; i++)
  {
  array[i] = new Random().Next(-9,10);
}
    return array;
}
 void PrintArray(int[] arr)
 {
for(int i = 0; i < arr.Length; i++)
{
System.Console.Write(arr[i] + " ");
}
 }
void SumArray(int[]arr)
{
  int sumPol = 0;
  int sumNeg = 0;
 for(int i = 0; i < arr.Length; i++)
  {
    if(arr[i] > 0) sumPol = sumPol + arr[i];
    else sumNeg = sumNeg + arr[i];
  }
Console.WriteLine("Сумма положительных чисел в массиве равна: " + sumPol);
 Console.Write("Сумма отрицательных чисел в массиве равна: " + sumNeg);
}
int[] userArray = GetRnd(12);
PrintArray(userArray);
Console.WriteLine();
  SumArray(userArray);
