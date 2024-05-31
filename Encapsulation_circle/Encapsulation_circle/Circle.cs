using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_circle;

public class Circle
{
    private double radius { get; set; }

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateDiameter()
    {
        return radius*2;
    }

    public double CalculateCircumference()
    {
        return 2*Math.PI*radius;
    }

    public double CalculateArea()
    {
        return Math.PI*Math.Pow(radius, 2);
    }

    public void Grow()
    {
        radius = radius*2;
    }

    public double GetRadius()
    {
        return radius;
    }

}
