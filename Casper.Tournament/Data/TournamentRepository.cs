using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casper.Tournament.Models;

namespace Casper.Tournament.Data
{
    public class TournamentRepository : DbContext
    {
        public DbSet<Models.Tournament> Tournaments { get; set; }

        public void InsertTournament(Models.Tournament tournament)
        {
            using(var db = new TournamentRepository())
            {
                db.Tournaments.Add(tournament);
                db.SaveChanges();
            }
        }

        public IEnumerable<Models.Tournament> GetAllTournaments()
        {
            using(var db = new TournamentRepository())
            {
                return db.Tournaments;
            }
        }
    }
}
