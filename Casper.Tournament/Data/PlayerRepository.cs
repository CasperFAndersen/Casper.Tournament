using Casper.Tournament.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casper.Tournament.Data
{
    public class PlayerRepository
    {
        public void InsertPlayer (Player player)
        {
            using (var db = new DatabaseContext())
            {
                db.Players.Add(player);
                db.SaveChanges();
            }
        }

        public IEnumerable<Player> GetAllPlayersInDb()
        {
            using(var db = new DatabaseContext())
            {
                return db.Players.ToList();
            }
        }
    }
}
