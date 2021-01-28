using System.ComponentModel.DataAnnotations;

namespace HotelEntities
{
    public class Personel : AEntity
    {

        [Required(ErrorMessage = "Maaş Girilmedi")]
        public int? Salary { get; set; }
        [Required(ErrorMessage = "Adres girilmedi")]
        public string Adress { get; set; }

    }
}
