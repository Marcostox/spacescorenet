using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceScore.DAL.Entities
{
    public class Team
    {
        public Guid Id { get; set; } // PK, GUID univoco per il team
        public string Name { get; set; } // Nome del team 
        public string LogoUrl { get; set; } // URL del logo del team
        public Guid CreatedBy { get; set; } // FK → Users.Id
        public DateTime CreatedAt { get; set; } // Data di creazione del team
    }
}
