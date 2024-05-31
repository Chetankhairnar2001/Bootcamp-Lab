using Encapsulation_circle;

Console.WriteLine("Welcome to the Circle Tester");

bool iscontinue=true;


try
{
    Console.WriteLine("Enter radius:");
    int radius = int.Parse(Console.ReadLine());
    Circle c1 = new Circle(radius);
    while (iscontinue)
    {

        Console.WriteLine("Diameter " + c1.CalculateDiameter());
        Console.WriteLine("Circumference " + c1.CalculateCircumference());
        Console.WriteLine("Area " + c1.CalculateArea());

        Console.WriteLine("Should the circle grow? (y/n) ");
        string user = Console.ReadLine();
        if (user == "n") iscontinue = false;
        if (user == "y")
        {
            Console.WriteLine("Cirlce is growing");
            c1.Grow();
        }
    }

    Console.WriteLine("Goodbye. The circle’s final radius is " + c1.GetRadius());
}
catch (Exception ex)
{
    Console.WriteLine(" please enter a valid type");
}

