/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементами массива.

[3 7 22 2 78] -> 76
*/
double[] GetArray(int size)
{
double[] result = new  double[size];
for (int i=0; i< size; i++){
    result[i]= Math.Round((new Random().NextDouble())*100);
}
  return  result; 
  }
  System.Console.WriteLine("Введите размер массива");

  int size=Convert.ToInt32(Console.ReadLine());
  double[] array=GetArray(size);

double max =array[0]; double min=array[0];
for (int i=1; i< size; i++){

   if (array[i]> max ) max=array[i];
 else min =array[i];
}

double difference=max-min;


System.Console.WriteLine($" Разность между max=  {max}  и min=  {min} элементами массива [{String.Join(" ; " , array)}] равна {difference}");