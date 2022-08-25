//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите колличество чисел");

  int size=Convert.ToInt32(Console.ReadLine());
  int[] array=GetArray(size);

int counter= GetCountPositive(array);
Console.WriteLine($" Количество положительных чисел  среди введенных [{String.Join("," , array)}] равно {counter}");
int[] GetArray(int size){
int[] result = new int [size];
for (int i=0; i< size; i++){
    Console.WriteLine($"Введите {i+1 } число");
     result[i]=Convert.ToInt32(Console.ReadLine());
     }
  return  result; 
  }

  
int GetCountPositive(int[] array){
    int count=0;
    for( int i=0; i<size; i++){

       if(array[i]>0)count++;

    }
return count;
}




