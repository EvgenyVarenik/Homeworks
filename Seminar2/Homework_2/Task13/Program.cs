// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

number = Math.Abs(number);

if (number/100 > 0)
{
    while (number/10 > 99)
    {
        number=number/10;
    }
    int res = number%10;
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("третьей цифры нет");
}