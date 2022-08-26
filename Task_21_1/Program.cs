//Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int m = new Random().Next(11);  //Решила задать массив произвольного размера из произвольных элементов.
int n = new Random().Next(11); 
int[,] matrix = new int[m,n];
for (int i = 0; i < matrix.GetLength(0); i++) 
{

for (int j = 0; j < matrix.GetLength(1); j++) 
{
matrix[i, j] = new Random().Next(-20,20); 
Console.Write(matrix[i, j] + "\t");
}
Console.WriteLine();
}

Console.Write("Введите позицию нужного   элемента массива двузначным числом: ");
int positionNumber = Convert.ToInt32(Console.ReadLine());

int row=positionNumber/=10;
int column = positionNumber%10;
  if (row<matrix.GetLength (0) &&  column <matrix.GetLength(1)+1){int number=matrix[row, column];// Здесь все считается с нуля
  Console.WriteLine($"Элемент с указанной позицией: {number}");
  }

   else{
    Console.WriteLine("Элеменоа с таким номером в заданном массиве нет");
}