using Casper.Tournament.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casper.Tournament.Data
{
    public class TeamRepository : DbContext
    {
        public DbSet<Team> Teams { get; set; }

        public void InsertTeam(Team team)
        {
            using(var db = new TeamRepository())
            {
                db.Teams.Add(team);
                db.SaveChanges();
            }
        }

        public IEnumerable<Team> GetAllTeams()
        {
            using(var db = new TeamRepository())
            {
                return db.Teams;
            }
        }
    }

}
