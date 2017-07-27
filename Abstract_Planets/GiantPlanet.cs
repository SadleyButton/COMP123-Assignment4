using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 25, 2017
/// Student Number: 300.280.496
/// GitHub Repo: https://github.com/SadleyButton/COMP123-Assignment4
/// Description: This is the Giant Planet Class that extends the Planet Abstract Class
/// Version 0.4 - Impliment methods IHasMoon and IHasRing to check values and return boolean result to corisponding interfaces.
///            - Extended class for IHasMoon and IHasRing interfaces
/// </summary>

namespace Abstract_Planets
{
    /// <summary>
    /// This is the Giant Planet Class
    /// </summary>
    public class GiantPlanet : Planet, IHasMoon, IHasRing
    {
        //PRIVATE INSTANCE VARIABLES (OR FIELDS)
        private string _type;

        //PRIVATE PROPERTIES
        

        //CONSTRUCTORS ------------------------------------------------------------------------
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this._type = type;
        }

        //PRIVATE METHODS

        //PUBLIC METHODS
        /// <summary>
        /// HasRing method queries the planet RingCount and returns a boolean operator if existing.
        /// </summary>
        /// <returns></returns>
        public bool HasRing()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else return  false;
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