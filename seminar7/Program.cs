// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++) 
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);

        return newArray;
}  

void Show2dArray(int[,] array)
{
    for(int i= 0; i < array.GetLength(0); i++)
    {
        for(int j= 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

Console.Write("Input number of rows ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of value ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of value ");
int max = Convert.ToInt32(Console.ReadLine());

//int[,] myArray = CreateRandom2dArray(m,n,min,max);
//Show2dArray(myArray);

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.


int[,] ArraySum(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++) 
            newArray[i,j] = i + j;
        return newArray;
}  

int[,] my2Array = ArraySum(m,n);
Show2dArray(my2Array);

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] ArrayKvadr(int[,] Arr)
{
    for(int i = 0; i < Arr.GetLength(0); i = i + 2)
        for(int j = 0; j < Arr.GetLength(1); j = j + 2) 
            Arr[i,j] *= Arr[i,j];
    
    return Arr;
}

int[,] arr = CreateRandom2dArray(m,n,min,max);
Show2dArray(arr);
int[,] itog =  ArrayKvadr(arr);
Console.WriteLine();
Show2dArray(itog);


// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int FindDiagSum(int[,] array)
{
    int sum = 0;
    
    if(array.GetLength(0) == array.GetLength(1))
        for(int i = 0; i < array.GetLength(0); i++)
            sum += array[i,i];
    return sum;
}
Console.WriteLine()
int m = Convert.ToInt32(Console.ReadLine());

*/