/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число");
string  numberA = Console.ReadLine();
int i=0;
int sum =0;


while (i< numberA.Length){ 
     sum = sum + numberA[i];
      i++;
}


System.Console.WriteLine($"сумма цифр числа  {numberA} равна {sum -numberA.Length*48}");


