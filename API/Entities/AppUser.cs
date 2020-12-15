using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        
        [MaxLength(100)]
        public string UserName { get; set; }
    }
}