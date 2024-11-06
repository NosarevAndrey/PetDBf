using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetDB.Models
{
    public class PetType
    {
        public int Id { get; set; }
        [Required] public string TypeName { get; set; }
    }
}
