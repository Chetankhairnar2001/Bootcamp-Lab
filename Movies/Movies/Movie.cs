using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies;

public class Movie
{
    public string movieName {  get; set; }
    public string category {  get; set; }
    public int runtime {  get; set; }
    public int year {  get; set; }

    public Movie(string movieName, string category, int runtime, int year)
    {
        this.movieName = movieName;
        this.category = category;
        this.runtime = runtime;
        this.year = year;
    }

}
