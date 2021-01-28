using System.ComponentModel.DataAnnotations;

namespace HotelEntities
{
    
    public abstract class AEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirsName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
