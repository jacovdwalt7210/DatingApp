using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using API.Extensions;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateOfBirth { get; set; }

        [MaxLength(100)]
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;

        [MaxLength(100)]
        public string Gender { get; set; }

        [MaxLength(2000)]
        public string Introduction { get; set; }

        [MaxLength(100)]
        public string LookingFor { get; set; }

        [MaxLength(2000)]
        public string Interests { get; set; }

        [MaxLength(100)]
        public string City { get; set; }

        [MaxLength(100)]
        public string Country { get; set; }
        
        public ICollection<Photo> Photos { get; set; }

        // public int GetAge()
        // {
        //     return DateOfBirth.CalculateAge();
        // }
    }
}