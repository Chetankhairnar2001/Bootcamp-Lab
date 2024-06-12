using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ROSHAMBO.Player;

namespace ROSHAMBO;

public class RandomPlayer : Player
{
    
    Random random = new Random();

    public RandomPlayer() : base("The_jets")
    {
    }

    public override Roshambo GenerateRoshambo()
    {
        return (Roshambo)random.Next(0,3);
    }


}
