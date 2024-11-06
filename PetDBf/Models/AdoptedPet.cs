using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetDB.Models
{
    public class AdoptedPet
    {
        public int Id { get; set; }

        [Required] public int PetId { get; set; }

        [ForeignKey("PetId")] public Pet Pet { get; set; } 

        [Required] public int ClientId { get; set; }

        [ForeignKey("ClientId")] public Client Client { get; set; } 

        public DateTime AdoptionDate { get; set; } = DateTime.Now;

    }
}
