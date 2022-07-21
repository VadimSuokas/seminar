// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void ShowNums(int n)
{
    if(n > 1)
        ShowNums(n - 1);
    
    Console.Write(n + " "); // Если нужно в обратную сторону, переносим перед рекурсией
}
 
// ShowNums(5);

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumOfDigits(int n)
{
    if(n >= 10)
    {
        return n % 10 + SumOfDigits(n / 10);
    }
    else return n;

}

// Console.WriteLine(SumOfDigits(12345));

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowNum (int m, int n)
{
    if(n>m)
        ShowNum(m, n-1);
    
    Console.WriteLine(n + " ");
}

ShowNum(1,10);
// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int Stepen(int a, int b)
{
    if(b>1)
        return a * Stepen(a, b-1);
    
    else return a;
}

Console.WriteLine(Stepen(3,4));