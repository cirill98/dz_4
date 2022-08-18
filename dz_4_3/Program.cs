// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] array = new int [8];
int index = 0;
while (index < array.Length)
{
    array[index] = new Random().Next();  
    Console.Write($"{array[index]}, ");
    index++;
}

// командой array[index] = new Random().Next(); в Next() на записываем диапозон, так как хотим вывести лубые рандомные числа.
