using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    public class Vierkant : Vorm
    {
        public double Rib { get; set; }

        public override double BerekenOppervlakte()
        {
            return Rib * Rib;
        }

        public Vierkant(string _name, double _rib)
        {
            Name = _name;
            Rib = _rib;
        }
    }
}
