using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /*
     * You have to get a new driver's license. You show up at the office at the same time as four other people. The office says they will see everyone in alphabetical order and it takes 20 minutes for them to process each new license. All of the agents are available now, and they can each see one customer at a time. How long will it take for you to walk out with your new license?

        Your input will be a string of your name me, an integer of the number of available agents, and a string of the other four names separated by spaces others.

        Return the number of minutes it will take to get your license.

        Examples
        License("Eric", 2, "Adam Caroline Rebecca Frank") ➞ 40
        // As you are in the second group of people.

        License("Zebediah", 1, "Bob Jim Becky Pat") ➞ 100
        // As you are the last person.

        License("Aaron", 3, "Jane Max Olivia Sam") ➞ 20
        // As you are the first.
     */
    internal class License
    {
        public static void LicenseTime(string myName, int agentNo, string otherName)
        {
            otherName = otherName+" "+myName;
            string[] names = otherName.Split(" ");
            Array.Sort(names);
            int waitingNo = Array.IndexOf(names, myName);
            int time = ((waitingNo / agentNo) + 1) * 20;

            Console.WriteLine($"The time takes is: {time}");
        }

        public static void Main1(string[] args)
        {
            Console.WriteLine("Enter your Name");
            string myName=Console.ReadLine();
            Console.WriteLine("Enter the number of agents present:");
            int agentNo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name of the other people with a white space");
            string otherName=Console.ReadLine();
            LicenseTime(myName, agentNo, otherName);
        }

    }
}
