//средний 26
Console.Write("Введите n:");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
switch (n)
{
    case 1:
        {
            double a = 0.4;
            double b = 2.3; double z = Math.Exp(x * x);
            double y = 0; if (x > 3.5 * a) y = (a * b * x) - Math.Cos((z * x) * (z * x));
            else if (3.5 * a <= x && (x <= b)) y = (a - x) * (a - x) - Math.Log(z + x); else if (x > b) y = Math.Sqrt(b * x - a + ((z * x) * (z * x)));
            Console.WriteLine($"y={y:F2}");
        }
        break;
    case 2:
        {
            double a = 0.2;
            double b = 0.8; double z = Math.Exp(x);
            double y = 0; if (x > 3.5 * a) y = (a * b * x) - Math.Cos((z * x) * (z * x));
            else if (3.5 * a <= x && (x <= b)) y = (a - x) * (a - x) - Math.Log(z + x); else if (x > b) y = Math.Sqrt(b * x - a + ((z * x) * (z * x)));
            Console.WriteLine($"y={y:F2}");
        }
        break;
    case 3:
        {
            double a = 0.7;
            double b = 8.1; double z = 0.8;
            double y = 0; if (x > 3.5 * a) y = (a * b * x) - Math.Cos((z * x) * (z * x));
            else if (3.5 * a <= x && (x <= b)) y = (a - x) * (a - x) - Math.Log(z + x); else if (x > b) y = Math.Sqrt(b * x - a + ((z * x) * (z * x)));
            Console.WriteLine($"y={y:F2}");
        }
        break;
}
