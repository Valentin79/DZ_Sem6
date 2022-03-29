// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

double Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    double Value = int.Parse(strValue);
    return Value;
}

double b1 = Prompt("Введите координату b1: ");
double k1 = Prompt("Введите координату k1: ");
double b2 = Prompt("Введите координату b2: ");
double k2 = Prompt("Введите координату k2: ");

Console.WriteLine($"Координаты пересечения x: {(b2 - b1)/(k1 - k2)}");
Console.WriteLine($"Координаты пересечения y: {k1 * (b2 - b1) / (k1 - k2) + b1}");