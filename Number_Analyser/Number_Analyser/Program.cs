Console.WriteLine("hello what is your name");
string username = Console.ReadLine();

Boolean stop = true;

while (stop! )
{
    Console.WriteLine($" hi {username} enter a integer no between 1 to 100 inclusive");
    int number = int.Parse(Console.ReadLine());
    if (number >= 1 && number <= 100)
    {
        if (number % 2 != 0 && number < 60)
            Console.WriteLine("Odd and less than 60.");
        else if (number % 2 == 0 && (number >= 2 && number <= 24))
            Console.WriteLine("Even and less than 25.");
        else if (number % 2 == 0 && (number >= 26 && number <= 60))
            Console.WriteLine("Even and between 26 and 60 inclusive.");
        else if (number % 2 == 0 && (number>60))
            Console.WriteLine("Even and greater than 60.");
        else
            Console.WriteLine("Odd and greater than 60.");

        Console.WriteLine("do you want to continue enter y or n");
        string ans = Console.ReadLine();
        if (ans == "n")
            stop = false;
    }
}
