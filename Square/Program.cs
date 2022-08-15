Console.WriteLine ("Введите первое число: ");
int a = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int b = int.Parse (Console.ReadLine());
if (a == b*b)
{
    Console.WriteLine ("Первое число квадрат второго");
    }
if (b==a*a)
{
    Console.WriteLine ("Второе число кватрат первого");
}
else
{
Console.WriteLine ("Числа не являются квадратами друг друга");
}