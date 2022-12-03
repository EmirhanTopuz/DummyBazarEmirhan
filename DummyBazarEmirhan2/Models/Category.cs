using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace DummyBazarEmirhan2.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Display(Name="kategori Adı")]
        [Required(ErrorMessage ="Alan Boş Brakılamaz")]
        [StringLength(maximumLength:50,ErrorMessage ="bu alan en fazla 50 karakter alabilir ")]
        public string Name { get; set; }
        [Display(Name = "Açıklama ")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

    }
}