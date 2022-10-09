//Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число");
int N= int.Parse(Console.ReadLine() ?? "0");
int i  = 1;
int pr = 1;
while (i<=N)
{
pr = pr*i;
++i;
}
Console.WriteLine(pr);

