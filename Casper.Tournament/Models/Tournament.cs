using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casper.Tournament.Models
{
    public class Tournament
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Team> ListOfTeams { get; set; }
        public int NumberOfTeams { get; set; }

        public Tournament(string name, string description, int numberOfTeams)
        {
            this.Name = name;
            this.Description = description;
            this.NumberOfTeams = numberOfTeams;
        }
    }
}
