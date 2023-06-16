using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CBank.Data;
using System;
using System.Linq;

namespace CBank.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any Clientes
                if (context.Clientes.Any())
                {
                    return;   // DB has been seeded
                }
                context.Clientes.AddRange(
                    new Cliente
                    {
                        ID = 1,
                        Nome = "João",
                        Sobrenome = "Silva Pereira",
                        DataNascimento = "01/02/1990",
                        Endereco = "Avenida Brasil, 123",
                        Cidade = "Belo Horizonte",
                        Estado = "Minas Gerais",
                        Pais = "Brasil",
                        Telefone = "555-1234",
                        Email = "joaosilvapereira@email.com",
                        Observacoes = "Abertura de conta em 2015"
                    },
                    new Cliente
                    {
                        ID = 2,
                        Nome = "Maria",
                        Sobrenome = "Silva Pereira",
                        DataNascimento = "18/05/1992",
                        Endereco = "Avenida Brasil, 123",
                        Cidade = "Belo Horizonte",
                        Estado = "Minas Gerais",
                        Pais = "Brasil",
                        Telefone = "555-1234",
                        Email = "mariasilvapereira@email.com",
                        Observacoes = "Abertura de conta em 2012"
                    },
                    new Cliente
                    {
                        ID = 3,
                        Nome = "Pedro Henrique",
                        Sobrenome = "Rodrigues",
                        DataNascimento = "12/06/1987",
                        Endereco = "Avenida Afonso Pena, 1233 Apto 101",
                        Cidade = "Belo Horizonte",
                        Estado = "Minas Gerais",
                        Pais = "Brasil",
                        Telefone = "555-0909",
                        Email = "pedror@email.com",
                        Observacoes = "Abertura de conta em 2010"
                    },
                    new Cliente
                    {
                        ID = 4,
                        Nome = "Ruth",
                        Sobrenome = "Costa",
                        DataNascimento = "10/07/1970",
                        Endereco = "Rua Pium-í, 222",
                        Cidade = "Belo Horizonte",
                        Estado = "Minas Gerais",
                        Pais = "Brasil",
                        Telefone = "555-2345",
                        Email = "ruthc@email.com",
                        Observacoes = "Abertura de conta em 1999"
                    },
                    new Cliente
                    {
                        ID = 5,
                        Nome = "Roberto",
                        Sobrenome = "Steibilish",
                        DataNascimento = "01/02/1955",
                        Endereco = "Rua Mangabeiras, 111 Apto 203",
                        Cidade = "Belo Horizonte",
                        Estado = "Minas Gerais",
                        Pais = "Brasil",
                        Telefone = "555-9686",
                        Email = "robertos@email.com",
                        Observacoes = "Abertura de conta em 1977"
                    },
                    new Cliente
                    {
                        ID = 6,
                        Nome = "Maria Helena",
                        Sobrenome = "Rosa",
                        DataNascimento = "01/02/1968",
                        Endereco = "Av Bias Fortes, 923 Apto 901",
                        Cidade = "Belo Horizonte",
                        Estado = "Minas Gerais",
                        Pais = "Brasil",
                        Telefone = "555-5644",
                        Email = "mariahelenarosa@email.com",
                        Observacoes = "Abertura de conta em 1987"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

