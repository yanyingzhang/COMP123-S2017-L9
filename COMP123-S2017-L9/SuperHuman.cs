using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.2 - Aded _initialize method
 */
namespace COMP123_S2017_L9
{
    /// <summary>
    /// This is the SuperHuman class.
    /// </summary>
    public class SuperHuman : Human
    {
        //PRIVATE INSTANCE VARIALES
        private List<Power> _prowers;

        //PUBLIC PROPERTIES

        //CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the SuperHuman class.
        /// It takes one parameter - name(string).
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name)
            :base(name)
        {
            this._initialize();
        }
        //PRIVATE METHODS

        /// This method initializes, instantiates and assigns values to class
        private void _initialize()
        {
            this._prowers = new List<Power>(); // creates an empty list
        }

        //PUBLIC METHODS

    }
}