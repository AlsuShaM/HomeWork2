﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int n = 55;
int a = (n / 100);
int b = ((n / 10) % 10);
int c = (n % 10);

if(n < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else Console.WriteLine(c);