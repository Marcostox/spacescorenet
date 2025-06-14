using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceScore.DAL.Entities
{
    public class Post
    {
        public Guid Id { get; set; } // PK, GUID univoco per il post
        public Guid UserId { get; set; } // FK → Users.Id, ID dell'utente che ha creato il post
        public string Content { get; set; } // Contenuto del post, può essere testo, link o altro
        public int? GameId { get; set; } // FK → Games.Id, ID del gioco associato al post (può essere null se non è associato a un gioco)
        public DateTime CreatedAt { get; set; } // Data e ora in cui è stato creato il post
    }
}
