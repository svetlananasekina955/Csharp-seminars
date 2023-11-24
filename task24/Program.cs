// 24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10

int Numbers1(int numb)
{
       int summ = 0;
    for(int i = 0; i <= numb; i++)
    {
     summ = summ + i;
    }
        return summ; 
}
Console.WriteLine("Введите число: ");
int userNumb = Convert.ToInt32(Console.ReadLine());
int result = Numbers1(userNumb);
Console.WriteLine($"Сумма чисел от 1 до {userNumb} = {result}");
