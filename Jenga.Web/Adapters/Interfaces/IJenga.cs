using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jenga.Models;

namespace Jenga.Web.Adapters.Interfaces
{
    public interface IJenga
    {
        Players GetPlayer(int id);
        List<Players> GetPlayers();
        void CreatePlayer(Players Player);
        void UpdatePlayer(int id, Players Players);
        void Delete(int id);
    }
}
