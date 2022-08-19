﻿/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
int[] GetArray(int size)
{
int[] result = new int [size];
for (int i=0; i< size; i++){
    result[i]= new Random().Next(-99,100);
}
  return  result; 
  }
  System.Console.WriteLine("Введите размер массива");

  int size=Convert.ToInt32(Console.ReadLine());
  int[] array=GetArray(size);

int GetSumOddPosition(int[] array)
{
int sum=0; 
for (int i=1; i< size; i+=2){
     sum=sum+array[i];
    
}
return sum;
}
int summa= GetSumOddPosition(array);
System.Console.WriteLine($" Сумма элементов, стоящих на нечетных позициях в массиве [{String.Join("," , array)}] равна {summa}");
