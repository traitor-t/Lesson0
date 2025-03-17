Console.WriteLine("Введите угол: ");
double alpha = Convert.ToInt32(Console.ReadLine());

double z1 = Math.Sin(4* alpha) / (1 + Math.Cos(4 * alpha)) * (Math.Cos(2 * alpha) / (1 + Math.Cos(2 * alpha)));
double z2 = 1.0 / Math.Tan((3 * Math.PI / 2) - alpha);

Console.WriteLine(z1);
Console.WriteLine(z2);