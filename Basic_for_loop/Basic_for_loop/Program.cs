string user_val = "y";
bool continue_sum=true;

while (continue_sum) { 
    Console.WriteLine("Enter a number:");
     int val = int.Parse(Console.ReadLine());
     int sum = 0;
     if(val > 0)
    {
        for(int i=1;i<=val;i++)
        {     
            sum += i;
        }
        Console.WriteLine(sum);
    }
     Console.WriteLine("Would you like to continue (y / n) ?");
    user_val = Console.ReadLine();
    if(user_val == "n")
    {
        continue_sum = false;
    }
 }


