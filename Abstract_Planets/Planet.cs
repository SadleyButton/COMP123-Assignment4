using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 25, 2017
/// Description: This is the Abstract Planet Class
/// Version 0.7 - Edit ToString override method to add units to results
/// </summary>
namespace Abstract_Planets
{
    public abstract class Planet
    {
        //PRIVATE INSTANCE VARIABLES (OR FIELDS)
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //PUBLIC PROPERTIES
        public double Diameter
        {
            get { return this._diameter; }
            private set { this._diameter = value; }
        }

        public double Mass
        {
            get { return this._mass; }
            private set { this._mass = value; }
        }

        public int MoonCount
        {
            get { return this._moonCount; }
            set { this._moonCount = value; }
        }

        public string Name
        {
            get { return this._name; }
            private set { this._name = value; }
        }

        public double OrbitalPeriod
        {
            get { return this._orbitalPeriod; }
            set { this._orbitalPeriod = value; }
        }

        public int RingCount
        {
            get { return this._ringCount; }
            set { this._ringCount = value; }
        }

        public double RotationPeriod
        {
            get { return this._rotationPeriod; }
            set { this._rotationPeriod = value; }
        }

        //CONSTRUCTORS  ==========================================================

        /// <summary>
        /// This is the main constructor for the Planet Class.
        /// It takes three parameters - name (string), diameter (double), mass (double)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name, double diameter, double mass)
        {
            this.Name = name;
            this.Diameter = diameter;
            this.Mass = mass;
        }

        //PRIVATE METHODS

        //PUBLIC METHODS

        /// <summary>
        /// This is the override ToString method to display the planet base information; name, diameter, and mass.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("=====================================================\n" +
                                 "Planet Information\n" +
                                 "\tName: {0}\n" +
                                 "\tDiameter: {1} km\n" +
                                 "\tMass: {2} (10^24kg)\n" +
                                 "=====================================================\n"
                                    , Name, Diameter, Mass);
        }
    }
}