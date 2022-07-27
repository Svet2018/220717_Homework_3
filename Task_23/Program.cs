//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

//Решение №1 задачи:

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < num; i++)
{
    int cube = (i+1)*(i+1)*(i+1); 

    //Возвести в степень можно другим способом:

    //int cub = Convert.ToInt32(Math.Pow(i + 1, 3));
    
    System.Console.Write($"{cube}, ");
}

System.Console.WriteLine();






