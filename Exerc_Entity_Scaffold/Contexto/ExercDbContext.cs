using Exerc_Entity_Scaffold.Models;
using Microsoft.EntityFrameworkCore;

namespace Exerc_Entity_Scaffold.Contexto;

public class ExercContexto : DbContext
{
    public ExercContexto(DbContextOptions<ExercContexto> options) : base(options) { }

    public DbSet<Cliente> Clientes { get; set; } = default!;
    public DbSet<Marca> Marcas { get; set; } = default!;
    public DbSet<Modelo> Modelos { get; set; } = default!;
    public DbSet<Carro> Carros { get; set; } = default!;
    public DbSet<Pedido> Pedidos { get; set; } = default!;
    public DbSet<Configuracao> Configuracoes { get; set; } = default!;

}

