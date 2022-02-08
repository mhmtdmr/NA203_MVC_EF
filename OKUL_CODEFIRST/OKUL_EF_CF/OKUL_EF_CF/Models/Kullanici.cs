using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OKUL_EF_CF.Models
{
    public abstract class Kullanici
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }

        [Required,MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        [NotMapped] // veritabanına işleme.
        public string Password2 { get; set; }
        public string Phone { get; set; }
    }
}
