using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("tblSorular")]
    public class Soru
    {
        [Key]
        public int SoruID { get; set; }
        [Required] //sorucümlesi zorunlu olsunu ifade eder.
        public string SoruCumlesi { get; set; }

    }
}
