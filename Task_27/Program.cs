//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)




int [, ,] matrix = new int [2,2,2];
string [,]matrix1=new string[4,2];
string[, ] index1 = new string [4,2];
string[, ] index2 = new string [4,2];
string[, ] index3 = new string [4,2];


for (int i = 0; i < 2;i++) {
       for (int j = 0; j < 2; j++) {
            for (int k = 0; k < 2; k++){
             matrix[i, j, k] = new Random().Next(10,100); 
            
            matrix1[i,j]=Convert.ToString(matrix[i,j,k]);
            index1[i,j]=Convert.ToString(k);
            index2[i,j]=Convert.ToString(j);
            index3[i,j]=Convert.ToString(i);

               Console.Write($"{matrix1[i,j]}[{index1[i,j]},{index2[i,j]},{index3[i,j]}] \t ");
            }
             Console.WriteLine();
       }
}
               
        
        


