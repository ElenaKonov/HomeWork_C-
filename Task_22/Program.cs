//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int size=columns;

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
              matrix[i, j] = new Random().Next(-10,10); 

               Console.Write(matrix[i, j] + "\t");
               }
         Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Сумма элементов столбцов матрицы:");

Console.WriteLine();


double[]sum =new double [size];

for (int j = 0; j < size; j++) {

 
    for (int i= 0; i < matrix.GetLength(0); i++) {
        
sum [j]+=matrix[i,j]; 
    }
Console.Write(sum[ j]/ matrix.GetLength(0)+ "\t");

//Console.Write(sum[ j]/ + "\t");
}

   

 