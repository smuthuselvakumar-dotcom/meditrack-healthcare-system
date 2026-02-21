using System.ComponentModel.DataAnnotations;

namespace MediTrack.API.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }
        
        public string? Address1 { get; set; }

        public string? Address2 { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public int? Country { get; set; }

        public int? PostalCode { get; set; }


    }
}
