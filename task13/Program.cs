// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите любое число: ");
int number = int.Parse(Console.ReadLine());
int tempNumb = number;
if (number > 99)
{
   while (number > 999)
   {
      number = number / 10;
   }
   Console.Write($"{tempNumb} -> третья цифра {number % 10}");
}
else
{
   Console.Write($"{number} -> третьей цифры нет");
}








