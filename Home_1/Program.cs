// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.WriteLine("Введите пятизначное число ");
int arg = Convert.ToInt32(Console.ReadLine());

if((arg / 10000) == (arg % 10) && (arg % 10000 / 1000) == (arg / 10 % 10))
    
    Console.WriteLine("Заданное число является ПАЛИНДРОМОМ.");

else
{
    Console.WriteLine("Заданное число НЕявляется ПАЛИНДРОМОМ.");    
}
