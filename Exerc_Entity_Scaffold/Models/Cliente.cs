using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exerc_Entity_Scaffold.Models
{
    [Table("clientes")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        [Column("id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("nome", TypeName = "varchar(100)")]
        public string Nome { get; set; } = default!;

        [Display(Name = "E-mail")]
        [Column("email", TypeName = "varchar(100)")]
        public string Email { get; set; } = default!;

        [Display(Name = "Telefone")]
        [Column("telefone", TypeName = "varchar(20)")]
        public string Telefone { get; set; } = default!;

        [Display(Name = "Endereço")]
        [Column("endereco", TypeName = "longtext")]
        public string Endereco { get; set; } = default!;
    }
}
