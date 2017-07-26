using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 25, 2017
/// GitHub Repo: https://github.com/SadleyButton/COMP123-Assignment4
/// Description: Assignment 4 - Abstract Planets
/// Version 0.5 - Create method to pause program
/// </summary>

namespace Abstract_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Saturn", 120536, 568, "GAS");
            Console.WriteLine(giantPlanet.ToString());

            WaitForAnyKey();

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12756, 5.97, true);
            Console.WriteLine(terrestrialPlanet.ToString());

            
            
        }
        /// <summary>
        /// Create a method to pause driver class and return a key stroke to continue program
        /// </summary>
        static void WaitForAnyKey()
            {
                Console.Write("Press a key to continue ...\n");
                Console.ReadKey(true);
                Console.WriteLine("");
            }
    } 
}
