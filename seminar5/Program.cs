// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму положительных элементов массива.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; // Инициализирует массив newArray

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
*/
/*
int[] CreateArray(int size)
{
    int[] newArray = new int[size]; 
    Console.Write("Creating array here: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}
*/

// Печать массива
/*
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
*/

//Печать массива
/*
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(size, min, max);
int[] array2 = CreateArray(size);

ShowArray(array1);
ShowArray(array2);
*/

int FindPositivSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i > 0]) sum += array[i];
    return sum;
}
int[] array1 = CreateRandomArray(size, min, max);
int sum = FindPositivSum(array);
Console.WriteLine("Sum of positive elements in current" + sum);