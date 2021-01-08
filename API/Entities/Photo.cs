using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }

        [MaxLength(500)]
        public string Url { get; set; }
        public bool IsMain { get; set; }
        
        [MaxLength(100)]
        public string PublicId { get; set; }

        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}