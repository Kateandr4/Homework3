// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine() ?? "0");
int i  = 1;
int cub = 1;
while (i<=N)
{
cub = i*i*i;
if (cub%2==0)
    {
        Console.WriteLine(cub);
    } 
++i;
    
}
