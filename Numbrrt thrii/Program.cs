Console.Clear();
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
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
int length = 7;
int[] array = ArrayMetode(length);
Print(array);
int Maximum(int maximum)
{
    int max = array[0];
    for (int i = 1; i < array.Length; ++i)
    {
        if (array[i] > max) max = Convert.ToInt32(array[i]);
    }
    System.Console.WriteLine($"max = {max}");
    return max;
}
int max = Maximum(0);
int Minimum(int minimum)
{
    int min = array[0];
    for (int i = 1; i < array.Length; ++i)
    {
        if (array[i] < min) min = Convert.ToInt32(array[i]);
    }
    System.Console.WriteLine($"min = {min}");
    return min;
}
int min = Minimum(0);
Console.WriteLine($"Разница между максимумом и минимумом: {max - min}");