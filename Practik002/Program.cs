
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int c = b % a;
string res;
if(c == 0)
{
    res = "кратно";
}
else
{
    res = $"не кратно, остаток: {c}";
}
Console.WriteLine($"{a}, {b} -> {res}");