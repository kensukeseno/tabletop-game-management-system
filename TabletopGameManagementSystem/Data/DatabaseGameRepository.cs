using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopGameManagementSystem.Models;

namespace TabletopGameManagementSystem.Data
{
    interface IGameRepository
    {
        List<Game> LoadGames();
    }

    internal class DatabaseGameRepository: IGameRepository
    {
        public List<Game> LoadGames() { return new List<Game>(); }
    }
}
