// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А");
int [] pointA = new int [3];
for (int i = 0; i < pointA.Length ; i++)
{
    pointA [i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите координаты точки B");
int [] pointB = new int [3];
for (int i = 0; i < pointB.Length ; i++)
{
    pointB [i] = Convert.ToInt32(Console.ReadLine());
}
double distanceX = Math.Pow((pointA[0] - pointB[0]), 2);
double distanceY = Math.Pow((pointA[1] - pointB[1]), 2);
double distanceZ = Math.Pow((pointA[2] - pointB[2]), 2);
double distance = distanceX + distanceY+distanceZ;
double dlina = Math.Sqrt(distance);
double dlinafinale = Math.Round(dlina, 3);
Console.WriteLine(dlinafinale);
