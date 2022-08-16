/*Задача 29: Напишите программу, которая задаёт массив из 
8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
int[] GetArray(int size)
{
int[] result = new int [size];
System.Console.WriteLine("Введите последовательно с клавиатуры элементы массива: ");

for (int i=0; i< result.Length; i++)
{
    result[i]=Convert.ToInt32(Console.ReadLine());
   
  }
  return  result; 
  }
int[] array=GetArray(8);
System.Console.WriteLine($"Результат: [{String.Join("," , array)}]"); 