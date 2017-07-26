using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Bradley Sutton
 * Date: July 25, 2017
 * Description: This is the Giant Planet Class that extends the Planet Abstract Class
 * Version 0.3 - FIX: Remove private property and directly associate type from constructor
 *             - ADD: public method for HasMoon
 *             - ADD: public method for HasRing
 */

namespace Abstract_Planets
{
    /// <summary>
    /// This is the Giant Planet Class
    /// </summary>
    public class GiantPlanet : Planet
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
        public bool HasRing()
        {
            throw new System.NotImplementedException();
        }

        public bool HasMoon()
        {
            throw new System.NotImplementedException();
        }
    }
}