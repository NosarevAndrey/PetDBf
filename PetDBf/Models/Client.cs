using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetDB.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public int GenderId { get; set; }
        [ForeignKey("GenderId")] public Gender Gender { get; set; }
        public string? Address { get; set; }
        [Phone] public string? PhoneNumber { get; set; }
        [EmailAddress] public string? Email { get; set; }


    }
}
