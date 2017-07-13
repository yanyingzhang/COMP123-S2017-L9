using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Yanying Zhang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.4 - Added another power to the SuperHuman object
 *              - Display all the powers in the Powers List
 */
namespace COMP123_S2017_L9
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.AddPower("Spider Climbing",50);
            superHuman.AddPower("Webcasting", 40);
            superHuman.AddPower("Phasing", 30);
            superHuman.AddPower("Invisibility", 25);
            Console.WriteLine(superHuman.ToString());

            
        }
    }
}
