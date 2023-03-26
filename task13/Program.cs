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








