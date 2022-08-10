/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Нужно сделать через числа, без индексов строк.
456 -> 5
782 -> 8
918 -> 1
*/ 
Console.WriteLine("Введите  число");
int numberA = Convert.ToInt32(Console.ReadLine());

if(numberA > 99 && numberA < 1000)
{
int secondDigit = numberA % 100 / 10;


Console.WriteLine($"Вторая   цифра числа {numberA}: {secondDigit}");
}

else
{
    Console.WriteLine("Введенное число не подходит по условию задачи.");
}