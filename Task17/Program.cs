// Напишите программу, которая принимает на вход координаты точки (X и Y), причем X!=0, и Y!= 0 
// и выдает номер четверти плоскости, в которой нахлжится эта точка.

int [] points = new int[2]; // 2 тк X и Y, вводим 2 раза
Console.WriteLine("Ввдите координаты X и Y");
for (int i = 0; i < points.Length ; i++)
{
    points [i] = Convert.ToInt32(Console.ReadLine()); //points от 0 равно введенному числу
}

if (points[0] > 0 && points[1] > 0 )
{
    Console.WriteLine("Четверть 1");
}
else if (points[0] > 0 && points[1] < 0)
{
    Console.WriteLine("Четверть 4");
}
else if (points[0] < 0 && points[1] > 0)
{
    Console.WriteLine("Четверть 2");
}
else if (points[0] < 0 && points[1] < 0 )
{
    Console.WriteLine("Четверть 3");
}
else
{
   Console.WriteLine("X или Y = 0"); 
}