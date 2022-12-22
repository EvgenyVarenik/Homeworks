// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

if (N > 1)
{
    while (index <= N)
    {
        double res = Math.Pow(index, 3);
        index++;
        Console.Write($"{res} ");
    }
    return;
}
else
{
    Console.Write($"N должен быть больше 1");
}

