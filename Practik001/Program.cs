
int number = new Random().Next(100, 1000);

int a = number / 100;
int b = number % 10;
int c = a * 10 + b;

Console.WriteLine($"{number} -> {c}");