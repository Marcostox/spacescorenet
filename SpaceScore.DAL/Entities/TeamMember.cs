using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceScore.DAL.Entities
{
    public class TeamMember
    {
        public Guid TeamId { get; set; } // FK → Teams.Id
        public Guid UserId { get; set; } // FK → Users.Id
        public string Role { get; set; } // Ruolo del membro nel team (es. "Leader", "Member", "Guest")
        public DateTime JoinedAt { get; set; } // Data in cui il membro si è unito al team
    }
}
