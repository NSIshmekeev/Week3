namespace Parking;


public enum Color
{
    RED, GREEN, BLUE, YELLOW, BLACK, WHITE,
}

public class Car
{
    public string Brand { get; }
    public string Model { get; }
    public Color  CarColor{ get; }
    public string CarNumber { get; }
    public DateTime? DateTime { get; set; } 

    public Car(string brand, string model, Color color, string carNumber)
    {
        Brand = brand;
        Model = model;
        CarColor = color;
        CarNumber = carNumber;
    }

    public Car(string brand, string model, Color color, string carNumber, DateTime dateTime)
    {
        Brand = brand;
        Model = model;
        CarColor = color;
        CarNumber = carNumber;
        DateTime = dateTime;
    }

    public override string ToString()
    {
        return $"Brand: {Brand}, Model: {Model}, Color: {CarColor}, Number: {CarNumber}: ArrivalTime: {DateTime}.";
    }
}

