using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_usedcards;

public class Used_Car : Car, Base_tostring
{
    public double mileage {  get; set; }

    public Used_Car(string make, string model, int year, decimal price, double mileage) : base(make, model, year, price)
    {
        this.mileage = mileage;
    }

    public override string ToString()
    {
        return $"{make} {model} {year} ${price} (Used) {mileage} miles";
    }

}
