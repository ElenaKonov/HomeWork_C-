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


int [,] GetArray(int m, int n)
{
int  [,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++) 
{

for (int j = 0; j < matrix.GetLength(1); j++) 
{
matrix[i, j] = new Random().Next(-10,10);
}
}
return matrix;
}


void PrintArray(int[,] inputMatrix)
{
for (int i = 0; i <inputMatrix.GetLength(0); i++)
{
for (int j = 0; j < inputMatrix.GetLength(1); j++)
{
Console.Write(inputMatrix[i, j] + "\t"); 
}
Console.WriteLine();
}
}
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);


int [] GetArraySum(int[,] resultMatrix){
int[]sum =new int [rows];

for (int i = 0; i < resultMatrix.GetLength(0); i++) {

        for (int j= 0; j < resultMatrix.GetLength(1); j++) {
        
             sum [i]+=resultMatrix[i,j]; 
          }
     } 
     return sum;
}  


void PrintArrayNew(int[] inputMatrix)
{
for (int i = 0; i <inputMatrix.Length; i++)

{
Console.WriteLine(inputMatrix[i] + "\t"); 
}
Console.WriteLine();
}

int[] resultSum = GetArraySum(resultMatrix);

Console.WriteLine();
PrintArrayNew(resultSum);



int  GetRowMinSum(int[] sum){


int min=sum[0]; int index=0;
for (int i=1; i< sum.Length; i++){
  if (sum[i]< min ) min=sum[i];
  if (min==sum[i]){index=i;}
   
 
}
return index;
}

int numberRow=GetRowMinSum(resultSum);
Console.WriteLine($"Строка с номером {numberRow}   имеет наименьшую сумму элементов");
