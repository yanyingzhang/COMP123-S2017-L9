using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Yanying Zhang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.2 - Instantiated an object of type SuperHuman
 */
namespace COMP123_S2017_L9
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.Powers.Add(new Power("Spider Clikbing", 50));
        }
    }
}
