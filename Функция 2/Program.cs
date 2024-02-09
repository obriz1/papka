

Double Square(Double rad)
{
    Double S = rad*rad*Math.PI;
    Console.Write($"Площадь окружности = ");
    return S;
}
Console.Write("Введите радиус окружности:");
Double rad = Convert.ToDouble(Console.ReadLine());

Double message = Square(rad);  
Console.Write(message);