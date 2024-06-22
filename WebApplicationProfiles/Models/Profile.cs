using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationProfiles.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("Division Description")]
        public string? DivisionDescription { get; set; }
    }
}
