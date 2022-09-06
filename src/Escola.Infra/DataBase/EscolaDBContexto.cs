using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Escola.Domain.Models;
using Escola.Infra.DataBase.Mappings;
using Microsoft.Extensions.Configuration;

namespace Escola.Infra.DataBase
{
    public class EscolaDBContexto : DbContext
    {
        public DbSet<Aluno> Alunos {get; set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder options){

            // options.UseSqlServer(_configuration.GetConnectionString("DevIn-Lab-Rest-Escola"));
           
            options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=BD_DevIn-Lab-Rest2-Escola;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new AlunoMap());
        }

        private readonly IConfiguration _configuration;
        public EscolaDBContexto(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}