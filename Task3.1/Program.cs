double x = 0.7;

double y = 20 * Math.Log(20) *  Math.Cos(Math.Exp(x)) - 2 / Math.Sqrt(Math.Pow(Math.Sin(Math.PI), 3) + Math.Abs(1 - Math.Pow(x,2)));
Console.WriteLine($"Значение функции y при x = {x}: {y}");