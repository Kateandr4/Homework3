// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine() ?? "0");
int i  = 1;
int cub = 0;
while (i<=N)
{
cub = (i)*(i)*(i);
Console.WriteLine(cub);
++i;
}
