//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

//Решение №1 задачи:

/*

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < num; i++)
{
    int cube = (i+1)*(i+1)*(i+1);     
    System.Console.Write(cube +  " ");
}

System.Console.WriteLine();

*/


//Решение №2 универсальное для степени числа

/*

System.Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень числа:");
int numPow = Convert.ToInt32(Console.ReadLine());
int number = 1;

int Sq(int arg1, int arg2)
{
    return Convert.ToInt32(Math.Pow(arg1,arg2));
}

while (number <= num)
{
    System.Console.Write(Sq(number, numPow) + " ");
    number++;  
}

System.Console.WriteLine();

*/


