using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceScore.DAL.Entities
{
    public class Tournament
    {
        public int Id { get; set; } // PK, ID univoco per il torneo
        public string Name { get; set; } // Nome del torneo
        public int GameId { get; set; } // FK → Games.Id, ID del gioco associato al torneo
        public Guid OrganizerId { get; set; } // FK → Users.Id, ID dell'utente organizzatore del torneo
        public string Type { get; set; } // Tipo di torneo (es. "Singolo", "Squadra", "Eliminazione diretta")
        public DateTime StartDate { get; set; } // Data di inizio del torneo
        public DateTime EndDate { get; set; } // Data di fine del torneo
        public string Reward { get; set; } // Descrizione della ricompensa per i vincitori del torneo
    }
}
