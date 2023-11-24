// 26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3    89126 -> 5

int Numbers1(int numb)
{    
    int summ = 0;
    {  
         summ = Math.Abs(numb).ToString().Length;

     // summ = (int)Math.Floor(Math.Log10(numb) + 1);
    }
        return summ; 
}
Console.WriteLine("Введите число: ");
int userNumb = Convert.ToInt32(Console.ReadLine());
int result = Numbers1(userNumb);
Console.WriteLine($"Количество цифр в числе {userNumb} = {result}");


