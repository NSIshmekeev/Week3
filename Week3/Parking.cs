namespace Parking;

public class Parking
{
    private List<Car> _cars = new List<Car>();

    public Car? this[int index]
    {
        get
        {
            if (index >= 0 && index < _cars.Count)
                return _cars[index];
            return null;
        }
        set
        {
            if (index >= 0 && index < _cars.Count)
                _cars[index] = value;
        }
    }

    public void AddCar(Car car)
    {
        if (_cars.Any(c => c.CarNumber == car.CarNumber))
        {
            throw new ArgumentException($"Машина с таким номером уже существует.");
        }
        car.DateTime = DateTime.Now;
        _cars.Add(car);
    }

    public void AddCar(string brand, string model, Color color, string carNumber)
    {
        if (_cars.Any(c => c.CarNumber == carNumber))
        {
            throw new ArgumentException($"Машина с таким номером уже существует.");
        }
        _cars.Add(new Car(brand, model, color, carNumber, DateTime.Now));
    }

    public void removeCar(Car car)
    {
        if (!_cars.Contains(car))
        {
            throw new KeyNotFoundException("Такой машины нет на парковке");
        }
        _cars.Remove(car);
    }

    public void removeCar(string carNumber)
    {
        var car = _cars.FirstOrDefault(c => c.CarNumber == carNumber);
        if (car == null)
        {
            throw new KeyNotFoundException("Такой машины нет на парковке");
        }
        _cars.Remove(car);
    }

    public void ShowInfo()
    {
        Console.WriteLine("Parking:");
        foreach (Car car in _cars)
        {
            Console.WriteLine(car);
        }
        Console.WriteLine();
    }


}
