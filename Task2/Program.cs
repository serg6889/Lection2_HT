// программa выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет

Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());

if( number >= 100)
{
    Console.Write("Third digit is ");
    Console.WriteLine(number % 10);
} 
else
{
    Console.WriteLine(" There is no third digit !!!");
}

