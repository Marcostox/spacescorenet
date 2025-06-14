using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceScore.DAL.Entities
{
    public class Match
    {
        public Guid Id { get; set; } // PK, GUID univoco per la partita
        public Guid? TournamentId { get; set; } // FK → Tournaments.Id, ID del torneo associato alla partita (può essere null se non è associata a un torneo)
        public int GameId { get; set; } // FK → Games.Id, ID del gioco associato alla partita
        public Guid TeamAId { get; set; } // FK → Teams.Id, ID del team A che partecipa alla partita
        public Guid TeamBId { get; set; } // FK → Teams.Id, ID del team B che partecipa alla partita
        public Guid? WinnerId { get; set; } // FK → Teams.Id, ID del team vincitore della partita (può essere null se non è ancora stato determinato il vincitore)
        public int ScoreA { get; set; } // Punteggio del team A
        public int ScoreB { get; set; } // Punteggio del team B
        public DateTime PlayedAt { get; set; } // Data e ora in cui è stata giocata la partita
    }
}
