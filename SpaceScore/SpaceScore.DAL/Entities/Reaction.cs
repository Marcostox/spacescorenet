using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceScore.DAL.Entities
{
    public class Reaction
    {
        public Guid Id { get; set; } // PK, GUID univoco per la reazione
        public Guid PostId { get; set; } // FK → Posts.Id, ID del post a cui è associata la reazione
        public Guid UserId { get; set; } // FK → Users.Id, ID dell'utente che ha creato la reazione
        public string Type { get; set; } // Tipo di reazione (es. "Like", "Dislike", "Love", "Angry", etc.)
        public DateTime CreatedAt { get; set; } // Data e ora in cui è stata creata la reazione
    }
}
