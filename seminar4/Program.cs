int FindSum(int a)
{
    int sum = 0;

    for(int current = 1; current <= a; current++) 
        sum += current; // sum = sum + current;
    return sum;
}

Console.WriteLine("Input positive intrger number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers from 1 to {num} is {FindSum(num)}");