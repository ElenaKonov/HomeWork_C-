/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
Console.WriteLine("Введите  число");
string numberA = Console.ReadLine();


if(numberA.Length < 5 || numberA.Length > 5)
{
    Console.WriteLine ("Ошибка ввода");
}

else
{
    if(numberA[0]==numberA[4] && numberA[1]==numberA[3])
    System.Console.WriteLine("Введенное число является палиндромом");
else {
    System.Console.WriteLine("ВВеденное число не является палиндромом");

}
   
   for(int start =4; start >=0; start--)
   System.Console.Write(numberA[start]);

}
    