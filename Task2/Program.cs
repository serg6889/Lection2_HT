// программa выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет

Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());

if( number < 100)
{
    Console.WriteLine(" There is no third digit !!!");
    
} 
else if (number >= 100)
{
    //Console.WriteLine(number.ToString().Substring(2,1));
    Console.WriteLine(number.ToString()[2]);

}





