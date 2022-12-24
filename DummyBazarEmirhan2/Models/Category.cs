using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DummyBazarEmirhan2.Models
{
    public class Category
    {
        public int ID { get; set; }

        public int? TopCategory_ID { get; set; }

        [ForeignKey("TopCategory_ID")]
        public virtual Category TopCategory { get; set; }

        [Display(Name = "kategori Adı")]
        [Required(ErrorMessage = "Alan Boş Brakılamaz")]
        [StringLength(maximumLength: 50, ErrorMessage = "bu alan en fazla 50 karakter alabilir ")]
        public string Name { get; set; }
        [Display(Name = "Açıklama ")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

    }
}