// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N;

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (N <= 0)
{
 Console.WriteLine("Некорректно заданы данные");   
}
else
{
while ( i < N );{
    int j = i * i;
    Console.WriteLine(j);
    i++;
    }
}