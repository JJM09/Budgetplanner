using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VactionBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            username = "Jay";

            string destination;
            destination = "Canada";

            string destination2;
            destination2 = "Japan";

            Console.WriteLine("Welcome to the Vaction Budget Planner");

            Console.WriteLine("Please enter your username");

            Console.WriteLine("Welcome " + username );

            Console.WriteLine("are you traveling to " + destination + "or" + destination2 + "?");

            Console.ReadLine();
                

        }
    }
}
