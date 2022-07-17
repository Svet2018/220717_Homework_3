// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// 14212 -> нет, 12821 -> да, 23432 -> да

void Palindrome(int number)
{
    string word = Convert.ToString(number);
    int wordLenght = word.Length;
    string newWord = String.Empty;

    for(int i = 0; i < wordLenght; i++)
    {
        char s = word[i];
        System.Console.WriteLine(s); 

      // System.Console.Write(word[i]);
       

       //System.Console.WriteLine("+++++++++++++++");  
       
    }  

    /*
    if (word == newWord)
    {
       System.Console.WriteLine($"Дано число {number}, которое является палиндромом."); 
    }
    else
    {
        System.Console.WriteLine($"Дано число {number}, которое не является палиндромом.");
    }
    */

}

Palindrome(987654);