using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("tblCevap")]
    public class Cevap
    {
        [Key]
        public int CevapID { get; set; }
        [ForeignKey("CevabıVerenKisi")] //bu FK'nın dolduracağı virtual Navigation Property CevabıVerenKisi'dir.
        public int KisiID { get; set; }
        [ForeignKey("Soru")]
        public int SoruID { get; set; }
        [Required]
        public Yanit Yanıt { get; set; }


        public virtual Kisiler CevabıVerenKisi { get; set; }
        public virtual Soru Soru { get; set; }



    }
    public enum Yanit
    {
       Hayır,
       Evet
    }
}
