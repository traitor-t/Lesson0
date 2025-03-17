Console.WriteLine("Введите длину окружности: ");
int length = Convert.ToInt32(Console.ReadLine());
double area = Math.Pow(length, 2) / (4 * Math.PI);
Console.WriteLine($"Площадь круга S: {area}");