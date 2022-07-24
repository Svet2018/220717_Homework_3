// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// 14212 -> нет, 12821 -> да, 23432 -> да

//Решение №1 задачи.


System.Console.WriteLine("Введите число:");
string word = Console.ReadLine();
int wordLenght = word.Length;
string wordReverse = "";

for (int i = word.Length - 1; i >= 0; i--)
{
    wordReverse += word[i];
};

if (wordReverse == word)
{
    System.Console.WriteLine("Введенное Вами число является палиндромом.");
}
else
{
    System.Console.WriteLine("Введенное Вами число не является палиндромом.");
};


//Решение №2 задачи.

/*
System.Console.WriteLine("Введите число:");
string word = Console.ReadLine();
string startHalfWord;
string endHalfWord;
int wordLenght = word.Length;
int middleWord = wordLenght / 2;
int moreMiddleWorld = middleWord + 1;
string outputEnd = "";

if (wordLenght % 2 == 0)
{
    startHalfWord = word.Substring(0, middleWord);
    endHalfWord = word.Substring(middleWord);
}
else 
{
    startHalfWord = word.Substring(0, moreMiddleWorld);    
    endHalfWord = word.Substring(middleWord);
};

for (int i = endHalfWord.Length - 1; i >= 0; i--)
{
    outputEnd += endHalfWord[i];
};

if (outputEnd == startHalfWord)
{
    System.Console.WriteLine("Введенное Вами число является палиндромом.");
}
else
{
    System.Console.WriteLine("Введенное Вами число не является палиндромом.");
};
*/


