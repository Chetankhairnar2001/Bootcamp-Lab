using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies;

public class Movie
{
    public string Title {  get; set; }
    public string category {  get; set; }
    public int runtime {  get; set; }
    public int year {  get; set; }

    public Movie(string Title, string category, int runtime, int year)
    {
        this.Title = Title;
        this.category = category;
        this.runtime = runtime;
        this.year = year;
    }

}
