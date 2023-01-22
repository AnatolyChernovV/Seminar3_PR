// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] coordsA = new double[3];
double[] coordsB = new double[3];
System.Console.WriteLine("Введите координату X точки А:");
coordsA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки А:");
coordsA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z точки А:");
coordsA[2] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату X точки B:");
coordsB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки B:");
coordsB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z точки B:");
coordsB[2] = Convert.ToInt32(Console.ReadLine());

double S = Math.Sqrt(Math.Pow(coordsB[0] - coordsA[0],2) + Math.Pow(coordsB[1] - coordsA[1],2) + Math.Pow(coordsB[2] - coordsA[2],2));
System.Console.WriteLine(S);

