Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

// Заполнение массива
// Матрица - табличка - двумерный массив
// m - строчки, n - столбцы
int[,] GetArray(int m, int n)
{
int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++) // по строчкам
{
// i, j, m, k
for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам
{
matrix[i, j] = new Random().Next(11); // [0;10]
}
}
return matrix;
}

int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
// Печать массива

void PrintArray(int[,] inputMatrix)
{
for (int i = 0; i < inputMatrix.GetLength(0); i++)
{
for (int j = 0; j < inputMatrix.GetLength(1); j++)
{
Console.Write(inputMatrix[i, j] + "\t"); // "\t" - Tab
}
Console.WriteLine();
}
}*/

nt[,] GetArrayNew(int rowsM, int columnsN)
{
    int[,] matrixNew = new int[rowsM, columnsN];
    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j ++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrixNew[i, j] = Convert.ToInt32(Math.Pow(i + j, 2));
            else matrixNew[i, j] = i + j;
         }
    }
    return matrixNew;
}
int[,] resultMatrix = GetArray(rowsM, columnsN);
PrintArray(resultMatrix);
Console.WriteLine();
int[,] resultMatrixNew = GetArrayNew(rowsM, columnsN);
PrintArray(resultMatrixNew);


nt GetSumDiagonal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            if (i == j) sum += matrix[i,j];
        }
    }
    return sum;
}
Console.WriteLine(GetSumDiagonal(resultMatrix));