// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine();
System.Console.WriteLine("Введите координаты первой точки:");
System.Console.WriteLine();
System.Console.WriteLine("Введите x1");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите y1");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите z1");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

System.Console.WriteLine("Введите координаты второй точки:");
System.Console.WriteLine();
System.Console.WriteLine("Введите x2");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите y2");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите z2");
int z2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int Sq(int arg1,  int arg2)
{ 
    return (arg2 - arg1)*(arg2 - arg1);
};

int SumResalt(int arg1, int arg2, int arg3)
{
    return arg1 + arg2 + arg3;
};

double SqResalt(int arg1)
{
    return Math.Sqrt(arg1); 
};

double resalt = SqResalt(SumResalt(Sq(x1, x2), Sq(y1, y2), Sq(z1, z2)));

System.Console.WriteLine("Расстояние  между двумя точками в 3D пространстве равно: {0:F2}", resalt);

