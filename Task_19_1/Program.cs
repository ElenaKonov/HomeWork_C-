//Задача 42: Напишите программу, которая будет 
//преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10





Console.WriteLine("Введите число");

int number=Convert.ToInt32(Console.ReadLine());
int sizeBinaryCod=Convert.ToInt32(Math.Round(Math.Log2(number))+1);// Вычисление длины двоичной формы записи числа с помощью математической формулы.
int  size= sizeBinaryCod;


int[] GetBinaryCod( int size){
int[] result=new int[  size];

while (number>0){
     for (int i=0; i<  size; i++) {
     result[size-1-i] =number%2;
 number=number/=2;
}
}
return result;
}
int [] array=GetBinaryCod(size);



Console.WriteLine($"{String.Join("", array)}");

