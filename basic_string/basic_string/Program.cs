
bool splits = true, joins = true;
string userinput;
while (splits)
{
    Console.WriteLine("Enter a sentence");
    userinput = Console.ReadLine();
    string[] arr = userinput.Split(" ");
    
    foreach(string s in arr)
        Console.WriteLine(s);

    Console.WriteLine("Do you want to continue? y or n");
    string ans = Console.ReadLine();
    if (ans == "n")
    {
        Console.WriteLine("Goodbye!");
        splits = false;
    }
}


List<string> list = new List<string>();
while (joins)
{
    Console.WriteLine("Enter some text");
    userinput = Console.ReadLine();
    list.Add(userinput);
    string soln = string.Join(" ", list);
    Console.WriteLine("You have entered: " + soln);

    Console.WriteLine("Would you like to continue (y/n)?");
    string ans = Console.ReadLine();
    if (ans == "n")
    {
        Console.WriteLine("Goodbye!");
        joins = false;
    }        
}