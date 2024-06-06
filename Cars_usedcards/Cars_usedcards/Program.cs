using Cars_usedcards;

List<Car> list = new List<Car>();
Car car1 = new Car("Tesla","model y",2020,45000);
Car car2 = new Car("BMW", "X 3", 2010, 65000);
Car car3 = new Car("Porsche", "911", 1977, 100000);

Used_Car car4 = new Used_Car("Bugati", "hyper-sports", 2020, 500000, 3459.0);
Used_Car car5 = new Used_Car("Toyota", "Camery", 2024, 8000, 34500.45);
Used_Car car6 = new Used_Car("Ferrari", "La Ferrari", 2014, 90909,124.909);

list.Add(car1);list.Add(car2);list.Add(car3);
list.Add(car4);list.Add(car5);list.Add(car6);

static void ListCars(List<Car> list)
{
    for(int i=0;i<list.Count; i++)
    {
        Console.WriteLine($"{i+1}. {list[i].ToString()}");
    }
}

static void Remove(List<Car> list, int index)
{
    list.RemoveAt(index);
}

static void yearList(List<Car> list,int year)
{
    List<Car> list2 = list.Where(x => x.year == year).ToList();
    Console.WriteLine(string.Join("\n",list2));
}

static void priceList(List<Car> list, decimal price)
{
    List<Car> list2 = list.Where(x => x.price <= price).ToList();
    Console.WriteLine(string.Join("\n", list2));
}

bool userinput = true;
Console.WriteLine("Welcome to Grant Chirpus’ Used Car Emporium!");
while (userinput)
{
    ListCars(list);
    Console.WriteLine("Which car would you like? ");
    int index = int.Parse(Console.ReadLine());
   if(index-1<list.Count)
    Remove(list, index-1 );
    Console.WriteLine("Excellent!  Our finance department will be in touch shortly.");
    Console.WriteLine("Enter year for which you want to search car");
    int year = int.Parse(Console.ReadLine());
    yearList(list, year);
    Console.WriteLine("Enter Price range for which you want to search car");
    decimal price = decimal.Parse(Console.ReadLine());
    priceList(list, price);
    Console.WriteLine("Do you want to continue? y:n");
    string user = Console.ReadLine();
    if (user == "n") userinput = false;

}

Console.WriteLine("Have a great day!");