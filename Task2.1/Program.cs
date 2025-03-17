Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
{
    Console.WriteLine("Ошибка, введите трехзначное число.");
    return;
}

string reversed = new string(number.ToString().Reverse().ToArray());
Console.WriteLine($"Число, полученное при прочтении его цифр справа налево: {reversed}");