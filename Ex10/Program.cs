int number;
while(true)
{
    Console.Write("Введите трёхзначное число: ");
    if (int.TryParse(Console.ReadLine(), out number))
        break;
    Console.WriteLine("Ошибка ввода!");
}
int a = number % 100;
int b = a / 10;
Console.WriteLine($"Результат: {number} -> {b}");