/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine($"A в степени B равно: {step}");

Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.



int sumtsifr (int num)
{
    int ed = num % 10;
    int des = num % 100/10;
    int hundred = num / 100;
    int tys = num / 1000;
    int sum =0;
    sum = ed+des+hundred+tys;
    return sum;
}
Console.WriteLine("введите число num");
int num = Convert.ToInt32(Console.ReadLine());
int sum=sumtsifr(num);
Console.WriteLine($"Сумма цифр в числе {num} равна {sum}");



int sumtsifr (int num)
{
  int sum =0;
  while (num>0)
  {
    sum=sum+(num%10);
    num=num/10;
  }
  return sum;
}
Console.WriteLine("введите число num");
int num = Convert.ToInt32(Console.ReadLine());
int resalt=sumtsifr(num);
Console.WriteLine($"Сумма цифр в числе {num} равна {resalt}");
*/


