int CutNumber()
{
    int num = new Random().Next(100,1000);
    Console.Write("Current random number is " + num);

    int sotni = num / 100;
    int ed = num % 10;

    int result = sotni * 10 + ed;
    return result;
}

int number = CutNumber();
Console.Write(" Result number is " + number); 
