/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


int[] GetArray(int size)
{
int[] result = new int [size];
for (int i=0; i< size; i++){
    result[i]= new Random().Next(100,1000);
}
  return  result; 
  }
  System.Console.WriteLine("Введите размер массива");

  int size=Convert.ToInt32(Console.ReadLine());
  int[] array=GetArray(size);

int GetCountEven(int[] array)
{
int count=0; int i=0;
while (i < size ){
    if(array[i]%2 == 0)count++;
    i++;
}
return count;
}
int counter= GetCountEven(array);
System.Console.WriteLine($" Количество четных чисел в массиве[{String.Join("," , array)}] равно {counter}");