//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B.
Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine("{0}:{1}", ("результат"),result);
