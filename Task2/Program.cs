Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    Console.WriteLine("Ошибка, введите трехзначное число.");
    return;
}

int firstnumber = number / 100;
int lastnumber = number % 10;
Console.WriteLine($"Первое число: {firstnumber}");
Console.WriteLine($"Последнее число: {lastnumber}");