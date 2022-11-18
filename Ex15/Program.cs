Console.WriteLine("Введите день недели: ");
string userInput = Console.ReadLine() ?? "";
int weekDay = int.Parse(userInput);
if(weekDay == 6 || weekDay == 7)
{
    Console.WriteLine($"Результат: {weekDay} -> да");
}
else
{
    Console.WriteLine($"Результат: {weekDay} -> нет");
}