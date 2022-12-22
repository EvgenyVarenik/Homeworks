// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
//int number = int.Parse(Console.ReadLine()!);

if (number > 0 && number < 100000)
{
    if (number/10000 == number%10)
    {
        if ((number/1000)%10 == (number%100)/10)
        {
            Console.WriteLine("Является палиндромом");
            return;
        }
    }
    Console.WriteLine("Не является палиндромом");
}
else
{
    Console.WriteLine("Не является палиндромом");
}