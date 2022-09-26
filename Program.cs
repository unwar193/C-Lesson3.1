﻿/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (14212 -> нет; 12821 -> да; 23432 -> да) */

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

if (num < 10000 || num > 100000)
{
    Console.WriteLine("Вы ввели некорректное число! Попробуйте ещё раз!");
};
if ((num % 10) == (num / 10000) && (num % 100) / 10 == (num / 1000) % 10)
{
    Console.WriteLine("Это палиндром!");
}
else
{
    Console.WriteLine("Это НЕ палиндром!!!");
};

/*     Console.WriteLine(num % 10 + ", " + num / 10000);
    Console.WriteLine((num % 100)/10 + ", " + (num / 1000)%10);
    Console.WriteLine((num % 1000)/100 + ", " + (num / 100)%10); */