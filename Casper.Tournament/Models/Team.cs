using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casper.Tournament.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Player> ListOfPlayers { get; set; }

        public Team(string name, List<Player> listOfPlayers)
        {
            this.Name = name;
            this.ListOfPlayers = listOfPlayers;
        }
    }
}
