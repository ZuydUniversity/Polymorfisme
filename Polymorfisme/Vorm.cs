using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    /// <summary>
    /// Vertegenwoordigt een geometrische vorm met een naam en een abstracte methode om de oppervlakte te berekenen.
    /// </summary>
    public abstract class Vorm
    {
        /// <summary>
        /// Geeft of stelt de naam van de vorm in.
        /// </summary>
        public string Name { get; set; } = null!;
        
        /// <summary>
        /// Berekent de oppervlakte van de vorm.
        /// </summary>
        /// <returns>De oppervlakte van de vorm.</returns>
        public abstract double BerekenOppervlakte();
    }
}
