

string length(string str)
{
    return($"Длинна Строки: {str.Length}"); 
}
Console.Write("Введите строку: ");
string str = Console.ReadLine();

string message = length(str);  
Console.Write(message);