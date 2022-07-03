// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input day of week N- ");
int weekDay = int.Parse(Console.ReadLine());

if ( weekDay == 6 || weekDay == 7)
{
    Console.WriteLine("This is weekend");
}
else
{
    Console.WriteLine("This is work day");
}
