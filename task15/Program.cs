Console.Write("Введите цифру, обозначающую день недели: ");
int number = int.Parse(Console.ReadLine());

if (number == 6 || number == 7)
{
   Console.Write($"{number} -> выходной, бегом за пивом");
}
else if (number >= 1 && number <= 5)
{
   Console.Write($"{number} -> рабочий день, соберись, тряпка");
}
else
{
   Console.Write($"{number} -> такого дня недели не существует, видимо, ты в Нарнии");
}

