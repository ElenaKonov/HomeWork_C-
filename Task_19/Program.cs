//Задача 42: Напишите программу, которая будет 
//преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10


int GetLengthBinaryCod(int number){
//int N=number;
int count=0;
while (number>0){
    
    //int g =number%2;
 number=number/=2;
count++;
}
return count;
}

Console.WriteLine("Введите число");
int number=Convert.ToInt32(Console.ReadLine());
int counter=GetLengthBinaryCod(number);

int[] GetBinaryCod( int counter){
int[] result=new int[counter];

while (number>0){
     for (int i=0; i< counter; i++) {
     result[counter-1-i] =number%2;
 number=number/=2;
}
}
return result;
}
int [] array=GetBinaryCod(counter);



Console.WriteLine($"[{String.Join(",", array)}]");