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
