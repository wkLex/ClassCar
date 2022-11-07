/*
    *LINQ(Language Integrated Query) in C#
    *LINQ is a uniform query language, introduced with .NET 3.5 that we can use to retrieve data from different data sources.
    *These data sources include the collection of objects, relational databases, ADO.NET datasets, XML files, etc.
    *Aggregate functions such as Count, Average, Min, Max, Sum,
    *Where, OrderBy(), OrderByDescending()

    *Think in terms of the loops – you don’t need a loop with LINQ. LINQ looping for you
    *Lambda expression  "=>"
*/

Console.WriteLine("Cars!");
List<Car> cars = new List<Car>();
Car car1 = new Car("Volvo", "V90", 2020, 220);
cars.Add(car1);

cars.Add(new Car("Saab", "900T", 2018, 200));

List<Car> extraCars = new List<Car>
{
    new Car("Opel","Vectra",2000, 180),
    new Car("Volvo","V60",1990,190)
};

cars.AddRange(extraCars);

cars.AddRange(new List<Car>
{
    new Car("Mercedes", "200D",1980,230),
    new Car("Fiat", "Tempo", 2010,180)
});

int higestSpeed = cars.Max(car => car.Speed);
double averageSpeed = cars.Average(car => car.Speed);
int sum = cars.Sum(car => car.Speed);
int countCars = cars.Count();

int countVolvo = cars.Where(car => car.Brand.Contains("Volvo")).Count();

Console.WriteLine("My Cars - Unsorted");
Console.WriteLine("Brand".PadRight(10) + "Model".PadRight(10) + "Year".PadRight(10) + "Speed");
foreach (Car car in cars)
{
    Console.WriteLine(car.Brand.PadRight(10) + car.Model.PadRight(10) + car.Year.ToString().PadRight(10) + car.Speed);
}

Console.WriteLine("---------------------");
Console.WriteLine("My Cars - Sorted by Brand");
List<Car> sortedCars = cars.OrderBy(car => car.Brand).ToList();
Console.WriteLine("Brand".PadRight(10) + "Model".PadRight(10) + "Year".PadRight(10) + "Speed");
foreach (Car car in sortedCars)
{
    Console.WriteLine(car.Brand.PadRight(10) + car.Model.PadRight(10) + car.Year.ToString().PadRight(10) + car.Speed);
}

Console.WriteLine("---------------------");
Console.WriteLine("My Cars - filtered by Year from 1980-1990");
List<Car> filteredCars = cars.Where(car => car.Year >= 1980 && car.Year <= 1990).ToList();
Console.WriteLine("Brand".PadRight(10) + "Model".PadRight(10) + "Year".PadRight(10) + "Speed");
foreach (Car car in filteredCars)
{
    Console.WriteLine(car.Brand.PadRight(10) + car.Model.PadRight(10) + car.Year.ToString().PadRight(10) + car.Speed);
}





Console.ReadLine();


class Car
{
    public Car(string brand, string model, int year, int speed)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Speed = speed;
    }

    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Speed { get; set; }
}

