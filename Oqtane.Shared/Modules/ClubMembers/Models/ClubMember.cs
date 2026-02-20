using System.ComponentModel.DataAnnotations;
using Oqtane.Models;

namespace Oqtane.Modules.ClubMembers.Models
{
    public class ClubMember : ModelBase
    {
        [Key]
        public int ClubMemberId { get; set; }
        public int ModuleId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        // reference to Oqtane File (photo)
        public int PhotoFileId { get; set; }

        // Finnish fields
        public string Ika { get; set; } // Ikä
        public string KuinkaPitkaanHarrastanut { get; set; }
        public string Pelivaineet { get; set; }
        public string MiksiBiljardi { get; set; }
        public string LempiLyonti { get; set; }
        public string Idoli { get; set; }
        public string Motto { get; set; }
    }
}
