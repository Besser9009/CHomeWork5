Console.Clear();
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
int length = 4;
int[] array = ArrayMetode(length);
Print(array);
int Sum(int summ)
{
    int sum = 0;
    for (int index = 1; index < array.Length; index += 2 )
    {
        sum += Convert.ToInt32(array[index]);
    }
    Console.WriteLine($"Summa = {sum}");
    return sum;
}
int sum = Sum(0);