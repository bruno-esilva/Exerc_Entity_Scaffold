using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exerc_Entity_Scaffold.Models
{
    [Table("carros")]
    public class Carro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        [Column("id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("nome", TypeName = "varchar(100)")]
        public string Nome { get; set; } = default!;

        [Display(Name = "Marca")]
        [Column("marca", TypeName = "varchar(100)")]
        public string Marca { get; set; } = default!;

        [Display(Name = "Modelo")]
        [Column("modelo", TypeName = "varchar(100)")]
        public string Modelo { get; set; } = default!;
    }
}
