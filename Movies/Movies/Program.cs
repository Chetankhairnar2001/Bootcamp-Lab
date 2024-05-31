using Movies;

class Program
{
    static void Main(string[] args)
    {
        // movie names from chatgpt //instantiation
        Movie m1 = new Movie("Toy Story", "Animated", 81, 1995);
        Movie m2 = new Movie("Finding Nemo", "Animated", 100, 2003);
        Movie m3 = new Movie("The Lion King", "Animated", 88, 1994);
        Movie m4 = new Movie("Frozen", "Animated", 102, 2013);
        Movie m5 = new Movie("Shrek", "Animated", 90, 2001);
        Movie m6 = new Movie("The Shawshank Redemption", "Drama", 142, 1994);
        Movie m7 = new Movie("Forrest Gump", "Drama", 142, 1994);
        Movie m8 = new Movie("The Godfather", "Drama", 175, 1972);
        Movie m9 = new Movie("A Beautiful Mind", "Drama", 135, 2001);
        Movie m10 = new Movie("Fight Club", "Drama", 139, 1999);
        Movie m11 = new Movie("The Exorcist", "Horror", 122, 1973);
        Movie m12 = new Movie("A Nightmare on Elm Street", "Horror", 91, 1984);
        Movie m13 = new Movie("The Conjuring", "Horror", 112, 2013);
        Movie m14 = new Movie("Get Out", "Horror", 104, 2017);
        Movie m15 = new Movie("Hereditary", "Horror", 127, 2018);
        Movie m16 = new Movie("Blade Runner", "Sci-Fi", 117, 1982);
        Movie m17 = new Movie("The Matrix", "Sci-Fi", 136, 1999);
        Movie m18 = new Movie("Inception", "Sci-Fi", 148, 2010);
        Movie m19 = new Movie("Interstellar", "Sci-Fi", 169, 2014);
        Movie m20 = new Movie("Star Wars: Episode IV - A New Hope", "Sci-Fi", 121, 1977);

        List<Movie> list = new List<Movie>();
        list.Add(m1); list.Add(m2); list.Add(m3); list.Add(m4); list.Add(m5); list.Add(m6); list.Add(m7); list.Add(m8);
        list.Add(m9); list.Add(m10); list.Add(m11); list.Add(m12); list.Add(m13); list.Add(m14); list.Add(m15); list.Add(m16);
        list.Add(m17); list.Add(m18); list.Add(m19); list.Add(m20);

        Dictionary<int,string> dict = new Dictionary<int,string>();
        dict.Add(1, "Animated"); dict.Add(2, "Drama");
        dict.Add(3, "Horror"); dict.Add(4, "Sci-Fi");

        Console.WriteLine($"Welcome to the Movie List Application! \n There are {list.Count} movies in this list.");

        string user_input = "y";
        while (user_input != "n")
        {
            Console.WriteLine("What category number are you interested in? " +
                "animated -> 1, drama -> 2, horror -> 3, scifi -> 4");
            int movie_cat = int.Parse(Console.ReadLine());
            
            foreach(Movie movie in list)
            {   if(movie.category == dict[movie_cat])
                Console.WriteLine($"{movie.Title} - released in {movie.year} - watchtime {movie.runtime} mins");
            }

            Console.WriteLine("Do you want to Continue? y or n");
            user_input = Console.ReadLine();

        }

    }
}
