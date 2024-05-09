class Program
{
    static void Main(string[] args)
    {
        String play = "y";
        do
        {
            int i = 0;
            Console.WriteLine("How many sides should each die have?");
            string val = Console.ReadLine();
            bool result = int.TryParse(val, out i);
            if (result)
            {
                int num1 = random_generator(i);
                int num2 = random_generator(i);
                Console.WriteLine($"You rolled a {num1} and a {num2} ({num1 + num2} total)");
                if (i == 6)
                {
                    Console.WriteLine(dice_roll1(num1, num2));
                    Console.WriteLine(dice_roll2(num1, num2));
                }

            }
            else
            {
                Console.WriteLine("Please enter in digit!!");
            }
            Console.WriteLine("Roll again? (y/n)");
            play = Console.ReadLine();
        }
        while (play != "n");
    }

    static int random_generator(int range)
    {
        Random rand = new Random();
        return rand.Next(1, range + 1); //range +1 since to include the last number as well for random
    }

    static String dice_roll1(int num1, int num2)
    {

        if (num1 == 1 && num2 == 1)
            return "Snake Eyes";
        else if ((num1 == 1 && num2 == 2) || (num1 == 2 && num2 == 1))
            return "Ace Deuce";
        else if (num1 == 6 && num2 == 6)
            return "Box Cars";
        else
            return "";

    }
    static String dice_roll2(int num1, int num2)
    {
        int total = num1 + num2;
        if (total == 7 || total == 11)
            return "Win";
        else if (total == 2 || total == 3 || total == 12)
            return "Craps";
        else
            return "";
    }
}
