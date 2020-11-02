using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WK1MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is declaring and intializing a variable
            string adjective1 = "brown";

            //This is declaring and intializing a variable
            string noun1 = "koala";

            //This is declaring and intializing a variable
            string verb1 = "climbed";

            //This is declaring and intializing a variable
            string adverb1 = "gently";

            //This is declaring and intializing a variable
            string adjective2 = "exquisite";

            //This is declaring and intializing a variable
            string noun2 = "treehouse";

            //This is declaring and intializing a variable 
            string noun3 = "rhino";

            //This is declaring and intializing a variable
            string adjective3 = "massive";

            //This is declaring and intializing a variable
            string verb2 = "Jog";

            //This is declaring and intializing a variable
            string adverb2 = "quickly";

            //This is declaring and intializing a variable
            string verb3 = "thanked";

            //This is declaring and intializing a variable
            string adjective4 = "amazing";

            Console.WriteLine(" Today I went to the zoo.I saw a " + adjective1 +
             noun1 + " jumping up and down its tree. He " + verb1 + adverb1 +
             " through the large tunnel that led to its " + adjective2 + noun2 +
            " .I got some peanuts and passed through the cage to a gigantic gray " + noun3 +
            " towering above my head. Feeding that animal made me hungry. I went to get " +
            " a " + adjective3 + "scoop of ice cream. Afterwards I had to" + verb2 + adverb2 +
           "to catch our bus. When I got home I " + verb3 + " my mom for a" + adjective4 + "day at the zoo.");

            Console.ReadLine(); 
                




        }
    }
}
