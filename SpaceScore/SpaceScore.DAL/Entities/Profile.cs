using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceScore.DAL.Entities
{
    public class Profile
    {
        public Guid UserId { get; set; } // FK → Users.Id

        public string? Bio { get; set; } // max 500 chars

        public string? Tags { get; set; } // JSON: array di tag preferenze

        public string? FavoriteGames { get; set; } // JSON o lista separata da virgole

        public string? SteamId { get; set; } // Integrazione Steam

        public string? EpicId { get; set; } // Integrazione Epic

        public string? PSNId { get; set; } // Integrazione PSN

        public string? XboxId { get; set; } // Integrazione Xbox

        public string? TwitchUrl { get; set; } // Link canale

        public string? YouTubeUrl { get; set; } // Link canale
    }
}
