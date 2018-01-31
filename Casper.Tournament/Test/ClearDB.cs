//using Casper.Tournament.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Casper.Tournament.Test
//{
//    public static class ClearDB
//    {
//        public static void ClearDatabase()
//        {
//            using (var context = new DatabaseContext())
//            {
//                context.Database.ExecuteSqlCommand(
//                    "DELETE FROM dbo.Players WHERE ID != -1");
//                context.SaveChanges();
//            }
//        }
//    }
//}


