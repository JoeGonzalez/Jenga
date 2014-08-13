using Jenga.Data;
using Jenga.Models;
using Jenga.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jenga.Web.Adapters
{
    public class JengaAdapter : IJenga
    {
        public Players GetPlayer(int id) 
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Players Players = Db.Players.Where(p => p.Id == id).FirstOrDefault();
            return Players;
        }
        public List<Players> GetPlayers() 
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            List<Players> Players = Db.Players.ToList();
            return Players;
        }
        public void UpdatePlayer(int id,Players Players) 
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.SaveChanges();
        }
        public void Delete(int id) 
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.SaveChanges();
        }


        public void CreatePlayer(Players Player)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.Players.Add(Player);
            Db.SaveChanges();
        }
    }
}