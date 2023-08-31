
double LineValueForY(double m, double x, double b)
{
    double Y = m * x + b;
    return Y;
}

double Y = LineValueForY(10.0, 5.5, 6.3);
Console.WriteLine(LineValueForY(20.0, 5.5, 6.3));

int Factorial(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result = result * i;
    }

    return result;
}

int nFact = Factorial(5);
Console.WriteLine(Factorial(10));