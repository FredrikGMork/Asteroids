using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsteroidsAPI.Models
{
    public class GameBoard
    {
        public Spaceship Spaceship { get; set; }
        public List<Asteroid> Astoroids { get; set; }
        public IPlayer Cannon { get; set; }
        public IPlayer Captain { get; set; }
        public bool OnGoing { get; set; }


    }
}
