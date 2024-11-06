using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetDB.Models
{
    public class Pet
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public int GenderId { get; set; }
        [ForeignKey("GenderId")] public Gender Gender { get; set; }
        [Required] public int TypeId { get; set; }
        [ForeignKey("TypeId")] public PetType PetType { get; set; }
        public int AgeMonth { get; set; }
        public string? Description { get; set; }

    }
}
