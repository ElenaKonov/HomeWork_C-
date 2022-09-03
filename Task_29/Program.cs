//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.Write("Введите  первое число : ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  второечисло: ");

int N = Convert.ToInt32(Console.ReadLine());
//int sum=0;
/// start  = начало (M), end - конец (N)
int SumNumbers(int start, int end)
{
    // Базовый случай
    if (start == end) return M; // start == end (start == N), возращаем число
    // Рекурсивный случай
    return (end+SumNumbers(start,end-1));
}

Console.WriteLine($"Сумма чисел от {M} до {N}: {SumNumbers(M, N)}");

