﻿// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());

if ( num >= 1 && num <= 5 )
    {
         Console.WriteLine("Этот день не является выходным");
     }
 if (num >= 6 && num <= 7)
     {
         Console.WriteLine("Этот день является выходным");
     }