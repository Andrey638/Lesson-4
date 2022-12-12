// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int number=Convert.ToInt32(Console.ReadLine());
int sum=0;
for (int i=0;number>0;i++)
{
    sum=sum+number%10;
    number/=10;
}
Console.WriteLine("Сумма чисел:{0}", sum);
