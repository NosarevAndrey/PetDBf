using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetDB.Models
{
    public class Gender
    {
        public int Id { get; set; }
        [Required] public string GenderName { get; set; }
    }
}
