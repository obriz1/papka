

String Reverse(string str)
{
    char [] nstr = str.ToCharArray();
    Array.Reverse(nstr);
    return new string(nstr);
}
Console.Write("Введите строку: ");
string str = Console.ReadLine();

string message = Reverse(str);  
Console.Write(message);