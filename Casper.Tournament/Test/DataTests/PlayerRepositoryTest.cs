using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casper.Tournament.Data;
using Casper.Tournament.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Casper.Tournament.Test.DataTests
{
    [TestClass]
    public class PlayerRepositoryTest
    {
        [TestMethod]
        public void InsertPlayerTest()
        {
            PlayerRepository PR = new PlayerRepository();
            
            Player a = new Player("Simpleton");
            a.Name = "Simpleton";

            PR.InsertPlayer(a);
            //PR.InsertPlayer(b);
            //PR.InsertPlayer(c);
            
            List<Player> testListOfPlayer = PR.GetAllPlayersInDb().ToList();

            Assert.AreEqual(testListOfPlayer.Count, 1);

            //Assert.AreEqual(testListOfPlayer[1].Name, "Kex");
            ClearDB.ClearDatabase();
        }
    }
}
