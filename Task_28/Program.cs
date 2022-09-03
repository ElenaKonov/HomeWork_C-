//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07


Console.Write("Введите количество строк: "); // можно любого размера квадратную матрицу ввести.
int rows = Convert.ToInt32(Console.ReadLine());  

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,]GetArray(int  m, int n){
int[,] matrix= new int[m, n];
int firstColumn=0;
int endColumn =n-1;
int firstRow=0;
int endRow=m-1;
int counter=1;

while (firstColumn <= endColumn && firstRow <= endRow){
          for (int i = firstColumn; i < endColumn+1 ; i++){
                
                    matrix[firstRow,i] =counter;
                    counter++;
}

                    firstRow++;
                  
                for (int i = firstRow; i < endRow+1; i++){
                    matrix[i,endColumn] =counter;
                    counter++;
                }
                    endColumn--;
                    
                   for (int i = endColumn; i > firstColumn-1; i--){

                         matrix[endRow,i] =counter++;
                   }
                    endRow--;
                       for (int i = endRow; i > firstRow-1; i--){
                          
                          matrix[i, firstColumn]=counter;
                          counter++;
                       }
                          firstColumn++;

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