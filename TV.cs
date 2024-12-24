public class TV : AVT
{
    private double screenSize;
    public double ScreenSize
    {
        get => screenSize;
        set => screenSize = ValidatePositive(value, "Размер экрана должен быть положительным.");
    }

    public string ScreenResolution { get; set; }
    public string TypeOfMatrix { get; set; }

    private int ramSize;
    public int RamSize
    {
        get => ramSize;
        set => ramSize = ValidatePositive(value, "Оперативная память должна быть положительной.");
    }

    public TV(string model = "Unknown", string manufacturer = "Unknown", double price = 0.0, int year = 2000,
                     double screenSize = 40.0, string screenResolution = "3840x2160", string typeOfMatrix = "LED", int ramSize = 2)
        : base(model, manufacturer, price, year)
    {
        ScreenSize = screenSize;
        ScreenResolution = screenResolution;
        TypeOfMatrix = typeOfMatrix;
        RamSize = ramSize;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Размер экрана: {ScreenSize} дюймов, Разрешение экрана: {ScreenResolution}, Тип матрицы: {TypeOfMatrix}, Оперативная память: {RamSize} GB");
    }

    private T ValidatePositive<T>(T value, string errorMessage) where T : IComparable<T>
    {
        if (value.CompareTo(default(T)) <= 0)
            throw new ArgumentException(errorMessage);
        return value;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Размер экрана: {ScreenSize} дюймов, Разрешение экрана: {ScreenResolution}, Тип матрицы: {TypeOfMatrix}, Оперативная память: {RamSize} GB";
    }
}