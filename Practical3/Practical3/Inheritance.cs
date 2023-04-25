using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    class Sponsor
    {
        protected string owner = "Rakuteen";
    }

    class Team : Sponsor
    {
        private string teamName;
        public void printInfo()
        {
            Console.WriteLine(owner + " " + teamName);
        }

        public static void Main()
        {
            Team team = new Team();
            team.teamName = "Simformers";
            team.printInfo();
        }
    }
    
}
