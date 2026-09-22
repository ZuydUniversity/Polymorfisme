using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    /// <summary>
    /// Vertegenwoordigt een vierkant met een naam en een zijde (rib).
    /// </summary>
    public class Vierkant : Vorm
    {
        /// <summary>
        /// Geeft of stelt de lengte van de zijde (rib) van het vierkant in.
        /// </summary>
        public double Rib { get; set; }

        /// <summary>
        /// Berekent de oppervlakte van het vierkant met de formule: oppervlakte = rib * rib.
        /// </summary>
        /// <returns>De oppervlakte van het vierkant.</returns>
        public override double BerekenOppervlakte()
        {
            return Rib * Rib;
        }
        
        /// <summary>
        /// Initialiseert een nieuwe instantie van de <see cref="Vierkant"/> klasse.
        /// </summary>
        /// <param name="name">De naam van het vierkant.</param>
        /// <param name="rib">De lengte van de zijde (rib) van het vierkant.</param>
        public Vierkant(string name, double rib)
        {
            Name = name;
            Rib = rib;
        }
    }
}
