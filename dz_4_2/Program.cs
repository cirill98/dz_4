// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Напишите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int total = 0;
int a1 = 0;
while (a > 0)
{
    a1 = a % 10;
    total += a1;
    a /= 10;
}
Console.WriteLine($"Сумма цифр равна {total}");