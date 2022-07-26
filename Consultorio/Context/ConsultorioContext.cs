
using Consultorio.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Context
{
    public class ConsultorioContext : DbContext
    {
        public ConsultorioContext(DbContextOptions<ConsultorioContext> options) : base(options)
        {

        }

        public DbSet<Agendamento> Agendamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var agendamento = modelBuilder.Entity<Agendamento>();

            agendamento.ToTable("tb_agendamento");
            agendamento.HasKey(tb => tb.Id);
            agendamento.Property(tb => tb.Id).HasColumnName("id").ValueGeneratedOnAdd();
            agendamento.Property(tb => tb.NomePaciente).HasColumnName("nomePaciente").HasColumnType("varchar(100)").IsRequired();
            agendamento.Property(tb => tb.Horario).HasColumnName("horario").IsRequired();
        }
    }
}