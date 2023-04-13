Console.Clear();
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] ArrayMetode(int length)
{
    int[] array = new int[length];
    for (int index = 0; index < length; ++index)
    {
        array[index] = new Random().Next(100, 1000);
    }
    return array;
}
void Print(int[] array)
{
    Console.Write("[");
    for (int index = 0; index < array.Length - 1; ++index)
    {
        Console.Write($"{array[index]}, ");
    }
    Console.Write($"{array[array.Length - 1]} ");
    Console.WriteLine("]");
}
int length = 21;
int[] array = ArrayMetode(length);
Print(array);
int Sum(int summ)
{
    int sum = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] %2 == 0) sum += 1;
    }
    Console.WriteLine($"Summa = {sum}");
    return sum;
}
int sum = Sum(0);