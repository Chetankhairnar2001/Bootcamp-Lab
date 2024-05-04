string secret_code = "13579";
string input_code = "00000";
int tries = 5;
Console.WriteLine("");

do
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
while ((tries > 0) && input_code != secret_code);

if (tries == 0)
    Console.WriteLine("Too many tries you are locked");
