using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSHAMBO;

public class HumanPlayer: Player
{
    public HumanPlayer(string name) : base(name)
    {
        this.name = name;
    }

    public override Roshambo GenerateRoshambo()
    {
        throw new NotImplementedException();
    }
}
