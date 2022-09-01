//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
//наименьшей суммой элементов.

//Например, задан массив:

// 1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int size=rows;

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
              matrix[i, j] = new Random().Next(-10,10); 

               Console.Write(matrix[i, j] + "\t");
               }
         Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Сумма элементов строки матрицы:");

Console.WriteLine();


 int[]sum =new int[size];

for (int i = 0; i < size; i++) {

 
    for (int j= 0; j < matrix.GetLength(1); j++) {
        
sum [i]+=matrix[i,j]; 
    }

//Console.WriteLine(sum[ i]+ "\t");  //если нужжно, можно сумму вывести
}
int index=0;
int min=sum[0];
for (int i=1; i< size; i++){

   if (sum[i]<min ) min=sum[i];
   if (min==sum[i]){index=i;}
}
   
   Console.WriteLine();

Console.WriteLine($"Строка с номером {index} имеет наименьшую сумму");