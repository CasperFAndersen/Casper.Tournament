using Casper.Tournament.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casper.Tournament.Data
{
    public class TeamRepository
    {

        public void InsertTeam(Team team)
        {
            using(var db = new DatabaseContext())
            {
                db.Teams.Add(team);
                db.SaveChanges();
            }
        }

        public IEnumerable<Team> GetAllTeams()
        {
            using(var db = new DatabaseContext())
            {
                return db.Teams;
            }
        }
    }

}
