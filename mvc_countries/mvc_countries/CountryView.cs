using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace mvc_countries;

public class CountryView
{
    public Country DisplayCountry;
    public void Display()
    {

        Console.WriteLine(DisplayCountry.Name + " is located in " + DisplayCountry.continent + " consists of colors " + 
            string.Join(" ",DisplayCountry.Colors));
    }

    public CountryView(Country country)
    {
        this.DisplayCountry = country;
    }

}
