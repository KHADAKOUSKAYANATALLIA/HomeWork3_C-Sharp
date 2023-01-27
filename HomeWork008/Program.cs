/* 
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом (НЕ использовать число как строку, 
то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. Используем операторы % и /).

14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool CheckPalindrome(int number)
{

    int digitOne = number / 10000;
   
    int digitTwo = number / 1000;
    digitTwo = digitTwo % 10;

    int digitFour = number / 10;
    digitFour = digitFour % 10;

    int digitFive = number % 10;

if (digitOne == digitFive && digitTwo == digitFour)
{
    return true;
}
else
{
    return false;
}
}

if (CheckPalindrome(number))
{
    Console.WriteLine("Число палиндром");
}
else
{
    Console.WriteLine("Число не палиндром");
}

