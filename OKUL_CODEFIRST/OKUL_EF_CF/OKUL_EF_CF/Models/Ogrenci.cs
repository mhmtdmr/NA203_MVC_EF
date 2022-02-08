using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OKUL_EF_CF.Models
{
    [Table("Ogrenciler")]
    public class Ogrenci:Kullanici
    {
        [Required]
        [Index]
        [MaxLength(10)]
        public string OkulNumara { get; set; }
        public string Sinif { get; set; }
        [Required]
        public int OgretmenID { get; set; }
        public Ogretmen Ogretmen { get; set; }

    }
}