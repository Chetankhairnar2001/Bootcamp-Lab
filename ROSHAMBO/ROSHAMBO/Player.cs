using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSHAMBO;

public abstract class Player
{   
    public string? name {  get; set; }
    public Roshambo roshambo { get; set; }
    public Player(string name)
    {
        this.name = name;
    }

    public abstract Roshambo GenerateRoshambo();

    public enum Roshambo{
        rock,paper,scissors
    }

}
