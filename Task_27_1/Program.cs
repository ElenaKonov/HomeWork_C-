///Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)



Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину массива: ");
int depth = Convert.ToInt32(Console.ReadLine());



int [, ,] matrix = new int[rows,columns,depth];
int rows1=rows*columns;
string [,]matrix1=new string[rows1,depth];
string[, ] index1 = new string [rows1,depth];
string[, ] index2 = new string [rows1,depth];
string[, ] index3 = new string [rows1,depth];


for (int i = 0; i < rows;i++) {
       for (int j = 0; j<columns; j++) {
            for (int k = 0; k < depth; k++){
             matrix[i, j, k] = new Random().Next(10,100); 
            
            matrix1[i,j]=Convert.ToString(matrix[i,j,k]);
            index1[i,j]=Convert.ToString(i);
            index2[i,j]=Convert.ToString(j);
            index3[i,j]=Convert.ToString(k);

               Console.Write($"{matrix1[i,j]}[{index1[i,j]},{index2[i,j]},{index3[i,j]}] \t ");
            }
             Console.WriteLine();
       }
}
               
        