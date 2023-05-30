// Вывод таблицы квадратов чисел от 1 до N
Console.WriteLine("Напишите число");
int N =Convert.ToInt32(Console.ReadLine());
int i = 1;
if (N <= 1)
{
    Console.WriteLine("Неправильные данные");
}
else
{
    while (i <= N)
    {
        int kvadrat = i * i ;
        Console.WriteLine(kvadrat);
        i++;
    }
}
