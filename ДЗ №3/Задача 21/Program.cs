Console.Write("Введите точку AX: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку AY: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку AZ: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку BX: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку BY: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку BZ: ");
int bz = Convert.ToInt32(Console.ReadLine());

double Distance(double ax, double ay, double az, double bx, double by, double bz)
{
    double xc = (ax - bx) * (ax - bx);
    double yc = (ay - by) * (ay - by);
    double zc = (az - bz) * (az - bz);
    double result = Math.Sqrt(xc + yc + zc);
    return result;
}

double res = Distance(ax, ay, az, bx ,by ,bz);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);