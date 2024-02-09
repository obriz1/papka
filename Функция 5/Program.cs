

int factorial(int num)
{
    int f = 0;
    for (int i = 1; i <= num; i++)
    {
        f = f + i;
    }
    Console.Write($"Факториал числа {num} = ");
    return f;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


int message = factorial(num);  
Console.Write(message);