/*Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите  число, соответствующее дню недели: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA <1 || numberA > 7)
{System.Console.WriteLine("Данные введены некорректно");}

if(numberA >=1 && numberA<=5)
{
System.Console.WriteLine("День не является выходным.");
}


if(numberA==6 || numberA == 7)
{ System.Console.WriteLine("День является выходным.");}


