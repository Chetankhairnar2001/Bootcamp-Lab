using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSHAMBO;

public class RockPlayer : Player
{
    public RockPlayer() : base("The_Sharks")
    {
    }

    public override Roshambo GenerateRoshambo()
    {
        return Roshambo.rock;
    }
}
