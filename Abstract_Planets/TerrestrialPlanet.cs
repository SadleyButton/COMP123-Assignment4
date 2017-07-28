using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 27, 2017
/// Student Number: 300.280.496
/// GitHub Repo: https://github.com/SadleyButton/COMP123-Assignment4
/// Description: This is the Terrestrial Planet Class
/// Version 0.5 - FIX: field and parameter in main constructor
///             - Added override ToString method for full TerrestiralPlanet Details
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
            this._oxygen = oxygen;
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

        /// <summary>
        /// This is the public override string for TerrestrialPlanet class to include enchanced planet details, if applicable.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string terrestrialPlanetDetails;

            terrestrialPlanetDetails = string.Format("=====================================================\n" +
                                 "Planet Information\n\n" +
                                 "\tName: {0}\n" +
                                 "\tDiameter: {1} km\n" +
                                 "\tMass: {2} (10^24kg)\n"
                                 , Name, Diameter, Mass);

            terrestrialPlanetDetails += string.Format(HasMoon() == true ? "\tMoon(s): {0}\n" : "", MoonCount);

            terrestrialPlanetDetails += string.Format(RingCount > 0 ? "\tRing(s): {0}\n" : "", RingCount);

            terrestrialPlanetDetails += string.Format(OrbitalPeriod > 0 ? "\tOrbital Period: {0} hours\n" : "", OrbitalPeriod);

            terrestrialPlanetDetails += string.Format(RotationPeriod > 0 ? "\tRotation Period: {0} days\n" : "", RotationPeriod);

            terrestrialPlanetDetails += string.Format(Habitable() == true ? "\n\tThis planet is habitable!!\n" : "\n\tThis planet is not habitable.\n");

            return terrestrialPlanetDetails;
        }
    }
}