﻿/*
//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
*/

int count1 = new Random().Next(100, 1000); ;
Console.WriteLine($"Сгенерировано число {count1}");

// 100 без остатка, потом на 10 с остатком, и склеиваем результаты

int num1 = count1 / 100;
int num2 = count1 % 10;
Console.Write($"{num1}{num2}");