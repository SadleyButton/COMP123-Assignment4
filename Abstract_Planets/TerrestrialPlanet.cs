using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 25, 2017
/// Description: This is the Terrestrial Planet Class
/// Version 0.2 - Add main constructor for the TerrestrialPlanet Class
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
    }
}