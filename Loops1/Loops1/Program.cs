string user_input;
do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue (y/n)?");
    user_input = Console.ReadLine();
}
while (user_input == "y");


user_input = "y";
while (user_input == "y")
{
    Console.WriteLine("Enter a number");
    int number = int.Parse(Console.ReadLine());

    for (int i = number; i >= 0; i--)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    for (int i = 0; i <= number; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    Console.WriteLine("Would you like to continue (y/n)?");
    user_input = Console.ReadLine();
}

string secret_code = "13579";
string input_code = "00000";
int tries = 5;
Console.WriteLine("");
while ((tries > 0) && input_code != secret_code)
{
    Console.WriteLine($"Enter a code to open the lock inital code {input_code}");
    input_code = Console.ReadLine();

    if (input_code == secret_code)
    {
        Console.WriteLine("Welcome Home");
        break;
    }
    tries--;
    Console.WriteLine($"You entered wrong code, {tries} tries left");

}
if (tries == 0)
    Console.WriteLine("Too many tries you are locked");

