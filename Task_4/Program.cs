Console.WriteLine("Введите  число");
int numberA = Convert.ToInt32(Console.ReadLine());

 
 int counter = 1;

 while(counter <= numberA)
 {
    if (counter % 2 == 0) 
    {
        System.Console.WriteLine(counter);
        
    }
    counter++;
 }