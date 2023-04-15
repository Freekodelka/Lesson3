/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.*/

Console.WriteLine ("Insert x1: ");
double x1 = double.Parse (Console.ReadLine());
Console.WriteLine ("Insert x2: ");
double x2 = double.Parse (Console.ReadLine());
Console.WriteLine ("Insert y1: ");
double y1 = double.Parse (Console.ReadLine());
Console.WriteLine ("Insert y2: ");
double y2 = double.Parse (Console.ReadLine());
Console.WriteLine ("Insert z1: ");
double z1 = double.Parse (Console.ReadLine());
Console.WriteLine ("Insert z2: ");
double z2 = double.Parse (Console.ReadLine());
Console.WriteLine (Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2)));



