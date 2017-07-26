using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 25, 2017
/// Description: Assignment 4 - Abstract Planets
/// Version 0.4 - Create a TerrestrialPlanet and display results
/// </summary>

namespace Abstract_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Saturn", 120536, 568, "GAS");
            Console.WriteLine(giantPlanet.ToString());

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12756, 5.97, true);
            Console.WriteLine(terrestrialPlanet.ToString());
        }
    }
}
