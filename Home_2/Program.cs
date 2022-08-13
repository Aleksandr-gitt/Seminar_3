// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты двух точек A и B в формате X/Y/Z :");
Console.WriteLine("Введите координату Х точки A :");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A :");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки A :");
int Az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х точки B :");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B :");
int By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B :");
int Bz = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((Bx-Ax),2) + Math.Pow((By-Ay),2) + Math.Pow((Bz-Az),2));

Console.WriteLine("Расстояние между указанными точками - " + result);