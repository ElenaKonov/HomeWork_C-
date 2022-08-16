/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введите число");
int  numberA = Convert.ToInt32(Console.ReadLine());
int GetSumDigits(int numberA)
{int sum=0;
while (numberA >0)
{ 
sum = sum+numberA % 10;
numberA=numberA/=10;}
return sum;
}

System.Console.WriteLine($"Сумма цифр в числе {numberA} ={GetSumDigits(numberA)}");