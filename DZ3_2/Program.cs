// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine() ?? "0");
int sum =0;
int i = 0;
while (A!=0)
{
sum = sum + A%10;
A=A/10;
}
Console.WriteLine(sum);