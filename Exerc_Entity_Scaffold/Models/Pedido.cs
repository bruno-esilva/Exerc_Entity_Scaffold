using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exerc_Entity_Scaffold.Models
{
    [Table("pedidos")]
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        [Column("id")]
        public int Id { get; set; }

        [Display(Name = "Cliente")]
        [Column("idCliente", TypeName = "int")]
        public int IdCliente { get; set; } = default!;

        [Display(Name = "Carro")]
        [Column("carro", TypeName = "varchar(100)")]
        public string Carro { get; set; } = default!;

        [Display(Name = "Data de Locação")]
        [Column("dataLocacao", TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateOnly DataLocacao { get; set; } = default!;

        [Display(Name = "Data de Entrega")]
        [Column("dataEntrega", TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateOnly DataEntrega { get; set; } = default!;
    }
}
