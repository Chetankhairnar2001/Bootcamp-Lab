using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_countries;

public class CountryListView
{
    public List<Country> Countries {  get; set; }

    public void Display()
    { int i = 0;
        foreach (var item in Countries)
        {
            Console.WriteLine($"{++i} {item.Name} ");
        }
    }

    public CountryListView(List<Country> list)
    {
        this.Countries = list;
    }

}
