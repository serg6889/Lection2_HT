// программa принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Input 3-digit number ");
int number = Convert.ToInt32(Console.ReadLine());

if( number >= 100 && number < 1000)
{
    Console.WriteLine(number % 10);
} 
else
{
    Console.WriteLine("Incorrect input !!!");
}
