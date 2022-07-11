// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
int[] ReverseArray(int[] array)
{
    int LastIndex = array.Length - 1;
    int size = array.Length;
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    int i = 0, j = array.Length - 1;

    /*
    while(i < j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        i++;
        j--;

    }

    return array;
}

int[] myArray = {3, 5, 1, 8, 2, 9, 4};

myArray = ReverseArray(myArray);

for(int i = 0; i < myArray.Length; i++)
    ConsoleWrite(myArray[i] + " ");
*/

// Перевод числа в двоичное значение
// 18 / 2 -> 9 0
// 9 / 2 -> 6 1


/*
string ChangeDigitSystem (int num)
{
    string resultNumber = string.Empty;

    while(num > 0)
    {
        resultNumber = num % 2 + resultNumber;
        num /= 2; // num = num / 2;
    }

    return resultNumber;
}

Console.WriteLine(ChangeDigitSystem(18));
*/

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

void Treugolnik(int a,int b, int c)
{
    if(a < b + c && b < c + a && c < a + b) 
        Console.Writeline("Треугольник существует");
    else
        Console.WriteLine("Такого треугольника не может существовать");

}
int a = Convert.ToInt32(Console.Readline());
int b = Convert.ToInt32(Console.Readline());
int c = Convert.ToInt32(Console.Readline());
Treugolnik(a,b,c);


// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
int[] Fibonacci(int N)
{
    int[] newArray = new int[N];
    Console.WriteLine("Creating array here: ");
    newArray[0] = 0;
    newArray[1] = 1;
    for(int i = 2; i < N; i++)
        newArray[i] = newArray[i - 1] + newArray[i - 2];
    return newArray;
}
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.Readline());

Fibonacci(num);