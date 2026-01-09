using FilmeApis.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
namespace FilmeApis.Data;


public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
    {
    }
    public DbSet<Filme> Filmes { get; set; }

}
