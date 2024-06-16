using mvc_countries;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_countries
{
    public class CountryController
    {
        public List<Country> CountryDb { get; set; }

        public CountryController()
        {
            CountryDb = new List<Country>
        {
            new Country { Name = "USA", continent = "North America", Colors = new List<string> { "Red", "White", "Blue" } },
            new Country { Name = "Germany", continent = "Europe", Colors = new List<string> { "Black", "Red", "Yellow" } },
            new Country { Name = "Italy", continent = "Europe", Colors = new List<string> { "Green", "White", "Red" } },
            new Country { Name = "Japan", continent = "Asia", Colors = new List<string> { "Red", "White" } },
            new Country { Name = "India", continent = "Asia", Colors = new List<string> { "Yellow", "Red" } },
            new Country { Name = "China", continent = "Asia", Colors = new List<string> { "Purple", "White","Green" } }
        };
        }

        public void CountryAction(Country country)
        {
            CountryView countryView = new CountryView(country);
            countryView.Display();
        }

        public void WelcomeAction()
        {
            CountryListView countryList = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            countryList.Display();
            do
            {
                Console.WriteLine("please select a country by index");
                try
                {
                    int index = int.Parse(Console.ReadLine());

                    CountryAction(CountryDb[index - 1]);
                    Console.WriteLine("Would you like to continue");
                }
                catch (Exception ex) { 
                Console.WriteLine(ex.Message);
                }     
            }while(Console.ReadLine() == "y");

        }

    }
}
