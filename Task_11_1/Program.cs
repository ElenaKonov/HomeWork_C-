
/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int GetExponNumbers(int A, int B)
{
   int exponent=1;
for (int i=1; i <= B; i++){
    exponent=exponent*A;
}
return exponent;
}
System.Console.WriteLine($" {A}^{B} = {GetExponNumbers(A,B)}");
