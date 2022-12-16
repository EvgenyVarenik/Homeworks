// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int startnumber = 1;

if (N>0)
{
    while (startnumber != N+1)
    {
        if (startnumber%2 == 0)
        {
            Console.WriteLine(startnumber);
        }
        startnumber++;
    }
}
else
    {
        Console.WriteLine("Чисел нет");
    }