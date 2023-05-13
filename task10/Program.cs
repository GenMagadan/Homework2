// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Random random = new Random();
int randNumb = random.Next(99, 999);

int number = (randNumb / 10) % 10;
Console.Write($"{randNumb} -> {number}");

