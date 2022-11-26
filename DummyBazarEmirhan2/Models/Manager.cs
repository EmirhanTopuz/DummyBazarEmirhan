using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DummyBazarEmirhan2.Models
{
    public class Manager
    {
        
        public int ID { get; set; }

        public int ManagerType_ID { get; set; }
        [ForeignKey("ManagerType_ID")]
        public virtual ManagerType ManagerType { get; set; }

        [Required(ErrorMessage ="Bu alan zorunludur")]
        [StringLength(75,ErrorMessage ="En Fazla 75 karakter olabilir")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "En Fazla 50 karakter olabilir")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(50, ErrorMessage = "En Fazla 50 karakter olabilir")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength:20,MinimumLength =8,ErrorMessage ="Şifre 8 ile 20 karakter arasında olmalıdır")]
        public  string Password { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(250, ErrorMessage = "En Fazla 250 karakter olabilir")]
        public string Mail { get; set; }


        public bool IsActive { get; set; }
    }
}