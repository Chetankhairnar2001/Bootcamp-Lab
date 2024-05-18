using System.Linq;

class Program
{
    static bool typeofValue(string user_input)
    {   
        user_input = user_input.ToLower();
        if ("hometown".Contains(user_input) || "favourite food".Contains(user_input))
        {
            return true;
        }
        else
            return false;
    }

    static string Userinfo(int num,string user_input, string[] hometown, string[] food, string[] name)
    {
        user_input = user_input.ToLower();
        if ("hometown".Contains(user_input))
        {
            return ($"{name[num-1]} is from {hometown[num - 1]}");
        }
        else
            return ($"{name[num - 1]} likes to eat {food[num - 1]}");
    }

    static void Main(string[] args)
    {
        string[] name = new string[] { "Jack", "Robert", "James", "Rahul", "Joe", "Charlie", "Adolf" };
        string[] hometown = new string[] { "Chicago", "Mississipie", "New York", "Arlington", "Nevada", "San Jose", "Dallas" };
        string[] favourite_food = new string[] { "Pasta", "Pizza", "Cheese", "Lasagna", "Fried Rice", "French Fries", "Burger" };
        bool is_continue = true;


        while (is_continue) {
            Console.WriteLine("Welcome!! Do you want to see list of all students? 'y' or 'n' ");
            string listname = Console.ReadLine();
            if (listname == "y")
            {
                Console.WriteLine("** List **");
                foreach(string names in name)
                    Console.Write(names +"  ");
                Console.WriteLine();
            }

            Console.WriteLine($"Welcome Back! Which student would you like to learn more about? Enter a number 1-{name.Length}:");
            int user_input = int.Parse( Console.ReadLine() );
            if( user_input <1 || user_input>hometown.Length ) {
                Console.WriteLine($"Please enter number between range 1-{name.Length}");
            }
            else
            {
                Console.WriteLine($"Student {user_input} is {name[user_input-1]}. What would you like to know? Enter 'hometown' or 'favorite food':");
                string user_type = Console.ReadLine();
                while(!typeofValue(user_type)) { 
                    Console.WriteLine("That category does not exist. Please try again. Enter 'hometown' or 'favorite food':");
                    user_type = Console.ReadLine();
                    
                }
                Console.WriteLine(Userinfo(user_input,user_type,hometown,favourite_food,name));
            }

            Console.WriteLine("Would you like to learn about another student? Enter 'y' or 'n':");
            string continue_case = Console.ReadLine();
            if( continue_case == "n") 
                is_continue = false;    

        }

    }
}