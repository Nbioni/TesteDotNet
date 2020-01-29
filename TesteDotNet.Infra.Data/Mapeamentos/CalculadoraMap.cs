using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TesteDotNet.Infra.Data.Mapeamentos
{
    public class CalculadoraMap : MapBase<Calculadora>
    {
        public override void Configure(EntityTypeBuilder<Calculadora> builder)
        {
            base.Configure(builder);
            builder.ToTable("CalculadoraOperacao");
            builder.Property(c => c.opcao).IsRequired().HasColumnName("Opcao").HasMaxLength(100);
            builder.Property(c => c.valores).IsRequired().HasColumnName("ValoresEntrada").HasMaxLength(100);
            builder.Property(c => c.resposta).IsRequired().HasColumnName("RespostaSaida").HasMaxLength(100);
        }
    }
}
