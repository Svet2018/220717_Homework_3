//Реализовать игру с компьютером "Камень, ножницы , бумага". Игра может продолжаться несколько раундов, каждый раунд начисляются очки победителю.

System.Console.WriteLine("Игра камень, ножницы, бумага");

System.Console.WriteLine();

System.Console.WriteLine($"Введите количество игровых раундов, которое Вы бы хотели сыграть за одну игру:");
int round = Convert.ToInt32(Console.ReadLine());

int resaltPlayer = 0;
int resaltPc = 0;

while (round > 0)
{
    System.Console.WriteLine($"Введите число: камень - 1, ножницы - 2, бумага - 3");
    string numPlayer =(Console.ReadLine());

    Random rnd = new Random();
    //int numPc = rnd.Next(1, 4);
    string numPc = Convert.ToString(rnd.Next(1, 4));
    
    if (numPlayer != numPc)
    {
        if (numPlayer == "1" && numPc == "2")
        {
            System.Console.WriteLine($"Вы выбрали - камень, компьютер выбрал - ножницы. Вы выиграли в этом раунде, т.к. камень ломает ножницы.");
            resaltPlayer += 1;
        }
        
        if (numPlayer == "2" && numPc == "3")
        {
            System.Console.WriteLine($"Вы выбрали - ножницы, компьютер выбрал - бумагу. Вы выиграли в этом раунде, т.к. ножницы  режут бумагу.");
            resaltPlayer += 1;
        }

        if (numPlayer == "3" && numPc == "1")
        {
            System.Console.WriteLine($"Вы выбрали - бумагу, компьютер выбрал - камень. Вы выиграли в этом раунде, т.к. бумага накрывает камень.");
            resaltPlayer += 1;
        }


        if (numPlayer == "2" && numPc == "1")
        {
            System.Console.WriteLine($"Вы выбрали - ножницы, компьютер выбрал - камень. Вы проиграли в этом раунде, т.к. камень ломает ножницы.");
            resaltPc += 1;
        }

         if (numPlayer == "3" && numPc == "2")
        {
            System.Console.WriteLine($"Вы выбрали - бумагу, компьютер выбрал - ножницы. Вы проиграли в этом раунде, т.к. ножницы  режут бумагу.");
            resaltPc += 1;
        }

        if (numPlayer == "1" && numPc == "3")
        {
            System.Console.WriteLine($"Вы выбрали - камень, компьютер выбрал - бумагу. Вы проиграли в этом раунде, т.к. бумага накрывает камень.");
            resaltPc += 1;
        }


    }
    else
    {
        System.Console.WriteLine($"Вы выбрали одно и то же.");
        System.Console.WriteLine($"В данном раунде - ничья.");
    }

    round--;

};


System.Console.WriteLine($"У Вас - {resaltPlayer} очков, у компьютера - {resaltPc} очков.");

if (resaltPc > resaltPlayer)
{
    System.Console.WriteLine($"В этой игре выиграл компьтер со счетом {resaltPc} : {resaltPlayer}.");
}
if (resaltPc == resaltPlayer)
{
    System.Console.WriteLine($"В этой игре ничья.");
}
if (resaltPc < resaltPlayer)
{
    System.Console.WriteLine($"В этой игре выиграли Вы со счетом {resaltPlayer} : {resaltPc}.");
    System.Console.WriteLine("ПОЗДРАВЛЯЕМ!!!");
}




