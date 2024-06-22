using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationProfiles.Models
{
    public class Aligner
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Profile")]
        public int ProfileId { get; set; }

        [Required]
        public int SubstrateSize { get; set; }
    }
}
