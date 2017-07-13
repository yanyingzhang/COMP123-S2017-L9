using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Yanying Zhang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.4 - Added another power to the SuperHero object
 *              - Display all the powers in the Powers List
 */
namespace COMP123_S2017_L9
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("SuperHero Dude",20);
            superHero.AddPower("Spider Climbing",50);
            superHero.AddPower("Webcasting", 40);
            superHero.AddPower("Phasing", 30);
            superHero.AddPower("Invisibility", 25);
            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Karma: "+ superHero.Karma);

            
        }
    }
}
