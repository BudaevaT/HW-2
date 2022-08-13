Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingDayOfWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Да, выходной.");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Неправильно задана цифра.");
    }
    else Console.WriteLine("Нет, не выходной.");
}

CheckingDayOfWeek(dayNumber);