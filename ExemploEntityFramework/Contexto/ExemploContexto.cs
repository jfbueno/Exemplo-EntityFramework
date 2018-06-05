using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploEntityFramework.Models;

namespace ExemploEntityFramework.Contexto
{
    // O contexto é a representação do banco de dados
    public class ExemploContexto : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        // Cada DbSet é a representação de uma tabela específica
    }
}
