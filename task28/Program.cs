// 28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24  5 -> 120

int Numbers1(int numb)
{
       int summ = 1;
    for(int i = 1; i <= numb; i++)
    {
     summ = summ * i;
    }
        return summ; 
}
Console.WriteLine("Введите число: ");
int userNumb = Convert.ToInt32(Console.ReadLine());
int result = Numbers1(userNumb);
Console.WriteLine($"Произведение чисел от 1 до {userNumb} = {result}");



