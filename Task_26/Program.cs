//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


Console.Write("Введите количество строк первой матрицы: ");
int rowsFirstMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов первой матрицы: ");
int columnsFirstMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк второй матрицы: ");
int rowsSecondMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов второй матрицы: ");
int columnsSecondMatrix = Convert.ToInt32(Console.ReadLine());



int[,] resultMatrix=new int [rowsFirstMatrix, columnsSecondMatrix];

int[,] matrixFirst = new int[rowsFirstMatrix, columnsFirstMatrix];

for (int i = 0; i < rowsFirstMatrix; i++) {
        for (int j = 0; j < columnsFirstMatrix; j++) {
              matrixFirst[i, j] = new Random().Next(-10,10); 

               Console.Write(matrixFirst[i, j] + "\t");
               }

         Console.WriteLine();
}


Console.WriteLine();

int[,] matrixSecond = new int[rowsSecondMatrix, columnsSecondMatrix];

for (int i = 0; i < rowsSecondMatrix; i++) {
        for (int j = 0; j < columnsSecondMatrix; j++) {
              matrixSecond[i, j] = new Random().Next(-10,10); 

               Console.Write(matrixSecond[i, j] + "\t");
               }
         Console.WriteLine();
}

Console.WriteLine();

if (columnsFirstMatrix == rowsSecondMatrix){

    for (int i =0 ; i<rowsFirstMatrix; i++){
        for (int j=0; j<columnsSecondMatrix; j++){
    
            for (int l=0; l<rowsSecondMatrix; l++){
                resultMatrix[i,j]=resultMatrix[i,j]+matrixFirst[i,l]*matrixSecond[l,j];
            }
                      
                       Console.Write(resultMatrix[i, j] + "\t");  
                 }
              System.Console.WriteLine();
        }
                      
            
        }  

else{ Console.WriteLine( "Введенные матрицы перемножить нельзя.");}       