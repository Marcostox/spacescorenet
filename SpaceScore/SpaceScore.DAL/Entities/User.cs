using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceScore.DAL.Entities
{
    public class User
    {
        public Guid Id { get; set; } // PK, GUID univoco per l'utente
        public string Username { get; set; } // Nome utente, unico
        public string Email { get; set; } // Email dell'utente, unica
        public string PasswordHash { get; set; } // Hash della password per la sicurezza
        public string AvatarUrl { get; set; } // URL dell'avatar dell'utente
        public string Country { get; set; } // Paese dell'utente
        public string Region { get; set; } // Regione dell'utente
        public string City { get; set; } // Città dell'utente
        public int Level { get; set; } // Livello dell'utente, basato su XP
        public int XP { get; set; } // Punti esperienza accumulati dall'utente
        public int Score { get; set; }  // Punteggio totale dell'utente
        public string Role { get; set; } // Ruolo dell'utente (es. "Admin", "User", "Moderator")
        public DateTime CreatedAt { get; set; } // Data di creazione dell'account utente
        public DateTime BirthDate { get; set; } // Data di nascita dell'utente, per calcolare l'età
    }
}
