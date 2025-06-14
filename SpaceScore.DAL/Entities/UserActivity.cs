using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceScore.DAL.Entities
{
    public class UserActivity
    {
        public Guid Id { get; set; } // PK, GUID univoco per l'attività dell'utente
        public Guid UserId { get; set; } // FK → Users.Id, ID dell'utente che ha effettuato l'attività
        public string Type { get; set; } // Tipo di attività (es. "Match", "Tournament", "Score", "Achievement")
        public Guid? RefId { get; set; } // ID di riferimento all'entità associata (es. MatchId, TournamentId, AchievementId), può essere null se non applicabile
        public int Points { get; set; } // Punti guadagnati per l'attività, può essere positivo o negativo
        public DateTime CreatedAt { get; set; } // Data e ora in cui è stata registrata l'attività
    }
}
