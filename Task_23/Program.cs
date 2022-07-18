//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/*
int[] CubeNumber(int num)
{
    int[] array1 = new int[num];
    for(int i = 0; i < array1.Length; i++)
    {
        int cube = num * num * num;
        array1.SetValue(cube, i);
        System.Console.WriteLine(array1);
    }


}

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

CubeNumber(number);
*/

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[num];
for(int i = 0; i < array1.Length; i++)
{
    int cube = num * num * num;
    array1.SetValue(cube, i);
    System.Console.WriteLine(array1);
}
