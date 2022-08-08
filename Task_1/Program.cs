Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber)
{
    System.Console.WriteLine( "ВВедены одинаковые числа");
}
else

       if (firstNumber > secondNumber)
{
    System.Console.WriteLine ("Максимальным является число " + firstNumber);
}

if (secondNumber > firstNumber)
{
    System.Console.WriteLine ("Максимальным является число " + secondNumber);
}


