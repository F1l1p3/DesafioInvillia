using System;
using System.Collections.Generic;
using System.Text;
using DesafioDotNet.Models;
using DesafioDotNet.Models.dto;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesafioDotNet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Jogo> Jogo {get; set;}
        public DbSet<Amigo> Amigo {get; set;}
        public DbSet<JogoEmprestadoDto> JogoEmprestado {get; set;}
    }
}
