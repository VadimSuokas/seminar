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
        
        Console.Writeline();
    }
}

Console.Write("Input number of rows ");
int m = Convert.ToInt32(Console.Readline());
Console.Write("Input number of columns ");
int n = Convert.ToInt32(Console.Readline());
Console.Write("Input number of value ");
int min = Convert.ToInt32(Console.Readline());
Console.Write("Input number of value ");
int max = Convert.ToInt32(Console.Readline());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);