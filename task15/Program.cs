﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

int dayNumber = 13;

if(1 <= dayNumber & dayNumber <= 5)
{
  Console.WriteLine("Будний день");
}
if(6 <= dayNumber & dayNumber <= 7)
{
  Console.WriteLine("Выходной день");
}
if(dayNumber > 7)
{
  Console.WriteLine("Введены некорректные данные");
}