using Microsoft.EntityFrameworkCore;
using ProjetoErr.Models;
using ProjetoErr.Utils;

namespace ProjetoErr.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Está comentando pois criei a migração apenas para testar.
            //Sei que estão trabalhando na opção de gerar script separado, porém merece atenção isso.

            /*modelBuilder.Entity<Marca>().HasData
            (
                 //Lista copiada de aulas anteriores
                new Marca() { IdMarca = 1, dsMarca = "Renault"}, 
                new Marca() { IdMarca = 2, dsMarca = "Fiat"},     
                new Marca() { IdMarca = 3, dsMarca = "Honda" }
                
            ); 

            //Início da criação usuário padrão
            Usuario user = new Usuario();
            Criptografia.CriarPasswordHash("123456", out byte[] hash, out byte[] salt);
            user.Id = 1;
            user.Username = "UsuarioAdmin";
            user.PasswordString = string.Empty;
            user.PasswordHash = hash;
            user.PasswordSalt = salt;            
            user.Latitude = string.Empty;
            user.Longitude = string.Empty;

             modelBuilder.Entity<Usuario>().HasData(user);*/
            //Fim da criação do usuário padrão.
        }

    }
}