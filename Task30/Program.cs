//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

//m = 2, n = 3 -> A(m,n) = 9

Console.Write("Введите  первое число : ");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int FuncAkkerman(int firstArg, int secondArg)
{
    
    if (firstArg== 0) return secondArg+1; 
      else 
            if(firstArg!= 0 &&  secondArg==0) return FuncAkkerman( firstArg-1,1);
                else
                      return FuncAkkerman(firstArg-1, FuncAkkerman(firstArg, secondArg-1));
}

    Console.WriteLine($"Значение функции Аккермана для чисел {m} и {n} равно {FuncAkkerman(m,n)}");

