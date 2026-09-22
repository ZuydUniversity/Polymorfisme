using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    /// <summary>
    /// Vertegenwoordigt een cirkel met een naam en een straal.
    /// </summary>
    public class Cirkel : Vorm
    {
        /// <summary>
        /// Geeft of stelt de straal van de cirkel in.
        /// </summary>
        public double Straal { get; set; }

        /// <summary>
        /// Berekent de oppervlakte van de cirkel met de formule: oppervlakte = π * straal^2.
        /// </summary>
        /// <returns>De oppervlakte van de cirkel.</returns>
        public override double BerekenOppervlakte()
        {
            return Math.PI * Straal * Straal;
        }

        /// <summary>
        /// Initialiseert een nieuwe instantie van de <see cref="Cirkel"/> klasse.
        /// </summary>
        /// <param name="name">De naam van de cirkel.</param>
        /// <param name="straal">De straal van de cirkel.</param>
        public Cirkel(string name, double straal)
        {
            Name = name;
            Straal = straal;
        }
    }
}
