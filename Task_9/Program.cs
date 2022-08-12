/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

 Console.Write("Введите координату x точки A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки A: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки : ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());


double result=Math.Sqrt(Math.Pow(xB-xA,2)+Math.Pow(yB-yA,2)+Math.Pow(zB-zA,2));
System.Console.WriteLine($"Расстояние между двумя точками A({xA},{yA},{zA}) и B({xB},{yB},{zB}) пространства R^3 равно: {result:f2}");
