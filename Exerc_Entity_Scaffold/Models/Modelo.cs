using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exerc_Entity_Scaffold.Models
{
    [Table("modelos")]
    public class Modelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        [Column("id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("nome", TypeName = "varchar(100)")]
        public string Nome { get; set; } = default!;
    }
}
