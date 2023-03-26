Random random = new Random();
int randNumb = random.Next(99, 999);

int number = (randNumb / 10) % 10;
Console.Write($"{randNumb} -> {number}");

