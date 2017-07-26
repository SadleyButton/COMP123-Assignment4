using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Bradley Sutton
 * Date: July 25, 2017
 * Description: This is the Giant Planet Class that extends the Planet Abstract Class
 * Version 0.2 - Create private properties for main GiantPlanet constructor
 *             - Create GiantPlanet Constructor extneding from Planet base
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
        private string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        //CONSTRUCTORS ------------------------------------------------------------------------
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this.Type = type;
        }

        //PRIVATE METHODS

        //PUBLIC METHODS
    }
}