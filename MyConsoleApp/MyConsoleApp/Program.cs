Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {DateTime.Now}");

DateTime today = DateTime.Today;
DateTime christmas = new DateTime(today.Year, 12, 25);

if (christmas < today)
{
    christmas = christmas.AddYears(1);
}

int daysUntil = (christmas - today).Days;
Console.WriteLine($"Days until Christmas: {daysUntil}");