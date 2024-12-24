using System.Diagnostics;
using System.Reflection;

public class AVT
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }

    private double price;
    public double Price
    {
        get => price;
        set => price = Validate(value, "Цена не может быть отрицательной.", v => v >= 0);
    }

    private int year;
    public int Year
    {
        get => year;
        set => year = Validate(value, $"Год должен варьироваться между 1960 и {DateTime.Now.Year}.", v => v >= 1960 && v <= DateTime.Now.Year);
    }

    public AVT(string model = "Unknown", string manufacturer = "Unknown", double price = 0.0, int year = 2020)
    {
        Model = model;
        Manufacturer = manufacturer;
        Price = price;
        Year = year;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Модель: {Model}, Производитель: {Manufacturer}, Цена: {Price} USD, Год: {Year}");
    }

    private T Validate<T>(T value, string errorMessage, Func<T, bool> predicate)
    {
        if (!predicate(value))
            throw new ArgumentException(errorMessage);
        return value;
    }

    public override string ToString()
    {
        return $"Модель: {Model}, Производитель: {Manufacturer}, Цена: {Price} USD, Год: {Year}";
    }
}