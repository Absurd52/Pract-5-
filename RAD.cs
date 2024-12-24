public class RAD : AVT
{
    private double numberOfPresets;
    public double NumberOfPresets
    {
        get => numberOfPresets;
        set => numberOfPresets = ValidatePositive(value, "Количество предустановок должно быть положительным.");
    }

    private int batteryCapacity;
    public int BatteryCapacity
    {
        get => batteryCapacity;
        set => batteryCapacity = ValidatePositive(value, "Емкость аккумулятора должна быть положительной.");
    }

    public RAD(string model = "Unknown", string manufacturer = "Unknown", double price = 0.0, int year = 2000,
               double numberOfPresets = 4, int batteryCapacity = 2000)
        : base(model, manufacturer, price, year)
    {
        NumberOfPresets = numberOfPresets;
        BatteryCapacity = batteryCapacity;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Количество предустановок: {NumberOfPresets}, Емкость аккумулятора: {BatteryCapacity} mAh");
    }

    // Универсальная валидация для любых положительных значений
    private T ValidatePositive<T>(T value, string errorMessage) where T : IComparable<T>
    {
        if (value.CompareTo(default(T)) <= 0)
            throw new ArgumentException(errorMessage);
        return value;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Количество предустановок: {NumberOfPresets}, Емкость аккумулятора: {BatteryCapacity} mAh";
    }
}