using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casper.Tournament.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = Name;
        }
    }
}
