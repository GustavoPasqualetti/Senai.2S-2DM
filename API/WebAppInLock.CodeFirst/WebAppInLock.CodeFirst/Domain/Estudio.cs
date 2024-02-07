using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppInLock.CodeFirst.Domain
{
    [Table("Estudio")]
    public class Estudio
    {
        [Key]
        public Guid IdEstudio { get; set; } = Guid.NewGuid();

        [Column(TypeName= "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do estudio obrigatorio")]

        public string? Nome { get; set; }
    }
}
