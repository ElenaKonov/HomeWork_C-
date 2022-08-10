/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите  число");
string numberA = Console.ReadLine();

if(numberA.Length < 3)
{
    Console.WriteLine ("Третьей цивры в числе нет");


}

else
{
   System.Console.WriteLine(" Третья цифра  в числе:" +numberA[2]);
}