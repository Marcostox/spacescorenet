using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceScore.DAL.Entities
{
    public class Game
    {
        public int Id { get; set; } // PK, ID univoco per il gioco
        public string Name { get; set; } // Nome del gioco
        public string Genre { get; set; }   // Genere del gioco (es. "Azione", "Avventura", "GDR")
        public string Platform { get; set; } // Piattaforma del gioco (es. "PC", "Console", "Mobile")
        public bool HasApi { get; set; } // Indica se il gioco ha un'API disponibile per l'integrazione
    }
}
