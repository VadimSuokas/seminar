int CutNumber()
{
    int num = new Random().Next(10,100);
    Console.Write("Current random number is " + num);

    int des = num / 10;
    int ed = num % 10;

    int result = sotni * 10 + ed;
    return result;
}

void IsQuad(int num1, int num2);
{
    int quad1 = num1 * num1;
    int quad2 = num2 * num2;
    if(num1 == quad2)
        Console.WriteLine("Yes");
    else
        if(num2 == quad1)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("NO");
}

