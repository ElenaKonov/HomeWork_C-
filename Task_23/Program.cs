//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());


double[,] GetArray(int m, int n)
{
double[,] matrix = new double[m, n];
for (int i = 0; i < matrix.GetLength(0); i++) 
{

for (int j = 0; j < matrix.GetLength(1); j++) 
{
matrix[i, j] = -1* Math.Round((new Random().NextDouble()*2-1)*10,2);
}
}
return matrix;
}


void PrintArray(double[,] inputMatrix)
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
double[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);


double[,] GetSortArray(double[,]resultMatrix)

{
double temp;
 int sizeRow=resultMatrix.GetLength(0);
int sizeColums=resultMatrix.GetLength(1);


for (int i = 0; i < sizeRow; i++) {
    for (int k = 0; k < sizeColums; k++) {
   
         for (int j = 0; j < sizeColums-1-k; j++) {  
    
              if(resultMatrix[i,j]<resultMatrix[i,j+1]) {  temp=resultMatrix[i,j];
                  resultMatrix[i,j] =resultMatrix[i,j+1];
                      resultMatrix[i,j+1]=temp;
    
                     }
    

    
                   }

               }
}
return resultMatrix;
}



 Console.WriteLine();

double[,] matrixSort= GetSortArray(resultMatrix);
PrintArray(matrixSort);


