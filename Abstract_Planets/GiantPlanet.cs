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
/// Version 0.5 - Added the public override ToString method for GiantPlanet details.
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


        /// <summary>
        /// This is the public override string for GiantPlanet to include enchanced planet details, if applicable.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string giantPlanetDetails;

            giantPlanetDetails = string.Format("=====================================================\n" +
                                 "Planet Information\n" +
                                 "\tName: {0}\n" +
                                 "\tDiameter: {1} km\n" +
                                 "\tMass: {2} (10^24kg)\n"
                                 , Name, Diameter, Mass);

            giantPlanetDetails += string.Format(HasMoon() == true ? "\tMoon(s): {0}\n" : "", MoonCount);

            giantPlanetDetails += string.Format(HasRing() == true ? "\tRing(s): {0}\n" : "", RingCount);

            giantPlanetDetails += string.Format(OrbitalPeriod > 0 ? "\tOrbital Period: {0} hours\n" : "", OrbitalPeriod);

            giantPlanetDetails += string.Format(RotationPeriod > 0 ? "\tRotation Period: {0} days\n" : "", RotationPeriod);

            return giantPlanetDetails;
        }
    }
}