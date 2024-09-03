namespace Parking;

internal class Program
{
    public static void Main(string[] args)
    {
        Parking parking = new Parking();
        Car car1 = new Car("BMW", "M3", Color.RED, "X876RT");
        parking.AddCar(car1);
        parking.AddCar("Mersedes", "E30", Color.WHITE, "R593AU");
        parking.ShowInfo();
        parking.removeCar(car1);
        parking.removeCar("R593AU");
        parking.ShowInfo();
        parking.AddCar("LADA", "VESTA", Color.RED, "M189UH");
        parking.ShowInfo();
    }
}