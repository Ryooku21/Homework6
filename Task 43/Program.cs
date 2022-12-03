// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение точки b1:");
double b1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите значение точки k1:");
double k1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите значение точки b2:");
double b2 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите значение точки k2:");
double k2 = Convert.ToDouble (Console.ReadLine());

double FindX (double bPoint1, double kPoint1, double bPoint2, double kPoint2)
{
double x = (bPoint2-bPoint1) / (kPoint1-kPoint2);
return x;
}

double FindY(double kPoint1, double bPoint1, double resX)
{
double y = kPoint1 * resX + bPoint1;
return y;
}

double xResult = Math.Round(FindX(b1,k1,b2,k2), 1);
double yResult = Math.Round(FindY(k1,b1,xResult), 1);

if (b1==b2 && k1==k2)
{
    Console.WriteLine("Прямые идентичны, все точки являются точками пересечения.");
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны, точки пересечения отсутствуют.");
} else 
{
    Console.WriteLine($"Координаты точки пересечения прямых {xResult} и {yResult}");
}




