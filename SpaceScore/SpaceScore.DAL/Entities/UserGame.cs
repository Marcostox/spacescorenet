using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceScore.DAL.Entities
{
    public class UserGame
    {
        public Guid UserId { get; set; } // FK → Users.Id
        public int GameId { get; set; } // FK → Games.Id
        public float HoursPlayed { get; set; } // Ore giocate nel gioco
        public string Rank { get; set; } // Classifica del gioco (es. "Bronzo", "Argento", "Oro")
        public string Achievements { get; set; } // JSON: lista di achievement sbloccati nel gioco
    }
}
