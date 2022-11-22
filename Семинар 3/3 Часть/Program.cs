// A(3,6); B(2,1) -> 5,09
// A(7,-5); B(1,-1) -> 7,21

// a 2 + b 2 = c 2 a^2 + b^2 = c^2


Console.Write("Введите точку XA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку YA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку YB: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distance(double xa, double ya, double xb, double yb)
{
    double xc = (xa - xb) * (xa - xb);
    double yc = (ya - yb) * (ya - yb);
    double result = Math.Sqrt(xc + yc);
    return result;
}

double res = Distance(xa, ya, xb, yb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);