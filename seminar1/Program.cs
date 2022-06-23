int num1, num2, quad;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2 * num2;

if(quad == num1)
{
    Console.WriteLine("First number is quad of second nuber");
}
else
{
    Console.WriteLine("First number is not a quad second number");
}


