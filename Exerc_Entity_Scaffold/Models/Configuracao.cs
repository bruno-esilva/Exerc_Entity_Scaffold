using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exerc_Entity_Scaffold.Models
{
    [Table("configuracao")]
    public class Configuracao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        [Column("id")]
        public int Id { get; set; }

        [Display(Name = "Dias de Locação")]
        [Column("diasLocacao", TypeName = "int")]
        public int DiasLocacao { get; set; } = default!;

    }
}
