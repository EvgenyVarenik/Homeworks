// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите первое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((Math.Abs(number)>99 && Math.Abs(number)<1000))
{
    int res1 = number/10;
    int res2 = res1%10;
    Console.WriteLine($"Вторая цифра числа: {Math.Abs(res2)}");
}

