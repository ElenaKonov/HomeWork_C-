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

Console.Write("Введите номер  строки нужного элемента : ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца нужного элемента: ");
int column = Convert.ToInt32(Console.ReadLine());
  if (row<matrix.GetLength (0)+1 &&  column <matrix.GetLength(1)+1){int number=matrix[row-1, column-1];// Я здесь вывожу элемент, 
                                                                                                       //считая позиции в матрице, как в математике, т е нумерую элементы матрицы 3*3так:
                                                                                                       //(1,1) (1,2) (1,3)
                                                                                                       //(2,1)(2,2) (2,3)
                                                                                                       //(3,1) (3,2)(3,3)
  Console.WriteLine($"Указанной  позиции соответствует элемент {number}");
  }

   else{
    Console.WriteLine("Элемента с таким номером в заданном массиве нет");
}
