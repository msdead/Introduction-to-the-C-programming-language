Console.WriteLine("Введите число b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2:");
double k2 = Convert.ToDouble(Console.ReadLine());



double XIntersection(double b1, double k1, double b2, double k2)
{
        double xIntersection = (b2 - b1) / (k1 - k2);
        return xIntersection;
}

double YIntersection(double b1, double k1, double xIntersection)
{
        double yIntersection = k1 * xIntersection + b1;
        return yIntersection;
}

void WriteResult (double b1, double k1, double b2, double k2, double xIntersection, double yIntersection)
{
if (b1==b2 & k1==k2) Console.WriteLine("Прямые совпадают");
else if (k1==k2) Console.WriteLine("Прямые параллельны друг другу") ;
else Console.WriteLine($"точка пересечения  ({xIntersection} ; {yIntersection})") ;
}

double xIntersection = XIntersection(b1,k1,b2,k2);
double yIntersection = YIntersection(b1,k1,xIntersection);
WriteResult(b1, k1, b2, k2, xIntersection, yIntersection);