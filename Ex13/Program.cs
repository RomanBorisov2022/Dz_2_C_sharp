int number;
Console.WriteLine("Введите трехзначное число: ");
while(true)
{
    if(int.TryParse(Console.ReadLine(), out number))
        break;
    Console.WriteLine($"Результат: Ошибка ввода!");
}
int c = number / 100;
if (c < 1)
{
    Console.WriteLine($"Результат: {number} -> Третьей цифры нет");
}
else
{
    int a = number % 100;
    int b = a % 10;
    Console.WriteLine($"Результат: {number} -> {b}");
}