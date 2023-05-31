// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// А(3,6); В(2,1) -> 5,09
// А(7,-5); В(1,-1) -> 7,21

Console.WriteLine("Введите координаты точки А");
int [] pointA = new int [2];
for (int i = 0; i < pointA.Length ; i++)
{
    pointA [i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите координаты точки B");
int [] pointB = new int [2];
for (int i = 0; i < pointB.Length ; i++)
{
    pointB [i] = Convert.ToInt32(Console.ReadLine());
}
double distanceX = Math.Pow((pointA[0] - pointB[0]), 2);
double distanceY = Math.Pow((pointA[1] - pointB[1]), 2);
double distance = distanceX + distanceY;
double dlina = Math.Sqrt(distance);
Console.WriteLine(dlina);
