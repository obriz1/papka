

int Sum(int num1, int num2)
{
    int result = num1 + num2;
    Console.Write($"{num1} + {num2} = ");
    return result;
}
Console.Write("Введите число 1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2:");
int num2 = Convert.ToInt32(Console.ReadLine());

int message = Sum(num1,num2);  
Console.Write(message);