// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A: ");
int a = Int32.Parse(Console.ReadLine());
int a1 = a;
Console.WriteLine("Введите число B: ");
int b = Int32.Parse(Console.ReadLine());

for (int i = 1; i < b; i++)
{
    a *= a1;
}    
Console.WriteLine(a);
