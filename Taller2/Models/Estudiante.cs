using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;

namespace Taller2.Models
{
    public class Estudiante
    {
        [Key]
        [MaxLength(9)]
        public string BannerId { get; set; }
        [MaxLength(100)]
        [DisplayName("Ingrese nomre:")]
        public string Nombre { get; set; }
        public string Hobbies { get; set; }
        public DateTime FechaMoidificacion { get; set; }
        public bool IeneBeca { get; set; }
        public int CarreraId { get; set; }
        [ForeignKey("CarreraId")]
        public Carrera? Carrera { get; set; }





    }
}
