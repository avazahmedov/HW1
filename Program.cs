﻿/*
Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Maximum = (number1);
int Minimum = (number2);

if (number2>number1)
{
    Maximum = Minimum;
    Minimum = number1;
    Console.WriteLine("Максимальное число " + Maximum);
    Console.WriteLine("Минимальное число " + Minimum);
}
else
{
    Console.WriteLine("Максимальное число " + Maximum);
    Console.WriteLine("Минимальное число " + Minimum); 
}
*/

/*
Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());

int Maximum = (number1);
int Minimum = (number2);

if (Minimum>Maximum)
{
   Maximum = Minimum;
   Minimum = number1;
}
if (number3>Maximum)
{
    Maximum = number3;
}
    Console.WriteLine("Максимальное число " + Maximum);
    */

/*
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
{
    Console.WriteLine(number + " это четное число ");
}
else 
{
    Console.WriteLine(number + " это нечетное число ");
}
*/

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int number = 1;

while (number<=N)
{
    if (number % 2 == 0)
    {
        Console.Write(number + ",");
        number+=2;
    }
    else 
    {
        number++;
    }
}
