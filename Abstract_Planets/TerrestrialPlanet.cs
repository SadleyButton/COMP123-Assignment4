using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 25, 2017
/// Description: This is the Terrestrial Planet Class
/// Version 0.4 - FIX: Bad copy, correction from HasRing to Habitable
/// </summary>
namespace Abstract_Planets
{
    public class TerrestrialPlanet : Planet, IHasMoon, IHabitable
    {
        //PRIVATE INSTANCE VARIABLES
        private bool _oxygen;

        //PRIVATE PROPERTIES

        //CONSTRUCTORS
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            oxygen = this._oxygen;
        }

        //PRIVATE METHODS

        //PUBLIC METHODS
        /// <summary>
        /// HasRing method queries the planet RingCount and returns a boolean operator if existing.
        /// </summary>
        /// <returns></returns>
        public bool Habitable()
        {
            if (_oxygen == true)
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// HasMoon method queries the planet RingCount and returns a boolean operator if existing.
        /// </summary>
        /// <returns></returns>
        public bool HasMoon()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else return false;
        }
    }
}