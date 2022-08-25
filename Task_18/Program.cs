//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите угловой коэффициент первой прямой k1");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите  коэффициент b1 первой прямой");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите угловой коэффициент второй прямой k2");
double k2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите  коэффициент b2  второй прямой");
double b2=Convert.ToDouble(Console.ReadLine());


if (k1==k2 && b1==b2){
    Console.WriteLine("Прямые совпадают");
}
if (k1==k2 && b1<b2 || b1>b2) {
    Console.WriteLine("Прямые параллельны");}

  if (k1>k2 || k1<k2 )
  { double xM=(b2-b1)/(k1-k2);
   double yM=k1*(b2-b1)/(k1-k2)+b1;
  
Console.WriteLine($"Прямые пересекаются в точке M({Math.Round(xM )}; {Math.Round(yM)})");} // Сделала округление вычислений до целого.
