using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang
 * Date: July 13, 2017
 * Description: This is the SuperVillain subclass of the SuperHuman base class 
 * Version: 0.1 - Create SuperVillain class
 */
namespace COMP123_S2017_L9
{
    /// <summary>
    /// This SuperVillain class is a subclass of SuperHuman
    /// It implements the IHasMalic Interface
    /// </summary>
    public class SuperVillain : SuperHuman, IHasMalice
    {
        // PRIVATE PROPERTIES
        private int _villain;
        // PUBLIC PROPERTIES
        public int Villain
        {
            get
            {
                return this._villain;
            }
            set
            {
                this._villain = value;
            }
        }
        // CONSTRACTOR
        public SuperVillain(string name, int villain)
            : base(name)
        {
            this._villain = villain;
        }
        // PRIVATE METHODS
        // PUBLIC METHODS
    }
}