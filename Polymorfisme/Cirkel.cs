using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    public class Cirkel : Vorm
    {
        public double Straal { get; set; }

        public override double BerekenOppervlakte()
        {
            return Math.PI * Straal * Straal;
        }

        public Cirkel(string _name, double _straal)
        {
            Name = _name;
            Straal = _straal;
        }
    }
}
