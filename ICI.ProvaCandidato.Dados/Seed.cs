using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Usuarios.Any() || context.Tags.Any() || context.Noticias.Any() || context.NoticiasTags.Any()) return;

            var usuarios = new List<Usuario>
            {
                new Usuario
                {
                    Id = 1,
                    Nome = "João",
                    Email = "joao@teste.com",
                    Senha = "123joao"
                },
                new Usuario
                {
                    Id = 2,
                    Nome = "Maria",
                    Email = "maria@teste.com",
                    Senha = "123maria"
                },
                new Usuario
                {
                    Id = 3,
                    Nome = "José",
                    Email = "jose@teste.com",
                    Senha = "123jose"
                },
            };

            var tags = new List<Tag>
            {
                new Tag
                {
                    Id = 1,
                    Descricao = "Notícias do Mundo"
                },
                new Tag
                {
                    Id = 2,
                    Descricao = "Notícias Locais"
                }
            };

            var noticias = new List<Noticia>
            {
                new Noticia
                {
                    Id = 1,
                    Titulo = "Lorem ipsum dolor sit amet",
                    Texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus faucibus orci sed quam faucibus lacinia. Fusce sit amet egestas dui, non efficitur tellus.",
                    UsuarioId = 2
                },
                new Noticia
                {
                    Id = 2,
                    Titulo = "Vestibulum fringilla augue at dolor egestas",
                    Texto = "Quisque lobortis nibh sed eros fringilla, eu blandit massa ultrices. Pellentesque elementum lectus ornare lectus aliquet, et rhoncus justo volutpat.",
                    UsuarioId = 1
                },
                new Noticia
                {
                    Id = 3,
                    Titulo = "Cras sed sollicitudin dolor",
                    Texto = "Cras molestie posuere leo nec condimentum. Pellentesque at neque ultricies, egestas lorem eget, tristique massa. Curabitur at accumsan tortor.",
                    UsuarioId = 1
                },
                new Noticia
                {
                    Id = 4,
                    Titulo = "Etiam non turpis euismod",
                    Texto = "Nullam molestie, arcu eu tempor dictum, mi est ultrices turpis, quis mollis nunc augue vel tellus. Integer pellentesque scelerisque nibh sit amet porttitor.",
                    UsuarioId = 1
                },
            };

            var noticiasTags = new List<NoticiaTag>
            {
                new NoticiaTag
                {
                    Id = 1,
                    NoticiaId = 1,
                    TagId = 2
                },
                new NoticiaTag
                {
                    Id = 2,
                    NoticiaId = 1,
                    TagId = 1
                },
                new NoticiaTag
                {
                    Id = 3,
                    NoticiaId = 2,
                    TagId = 1
                },
                new NoticiaTag
                {
                    Id = 4,
                    NoticiaId = 3,
                    TagId = 1
                },
                new NoticiaTag
                {
                    Id = 5,
                    NoticiaId = 3,
                    TagId = 2
                }
            };

            await context.Usuarios.AddRangeAsync(usuarios);
            await context.Tags.AddRangeAsync(tags);
            await context.Noticias.AddRangeAsync(noticias);
            await context.NoticiasTags.AddRangeAsync(noticiasTags);

            await context.SaveChangesAsync();
        }
    }
}
