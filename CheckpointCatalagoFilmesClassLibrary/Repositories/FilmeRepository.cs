using CheckpointCatalagoFilmesClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CheckpointCatalagoFilmesClassLibrary.Repositories
{
    public class FilmeRepository
    {
        private static readonly List<Filme> filmes = new List<Filme>
        {
            new Filme { Id = 1, Titulo = "Oppenheimer", Descricao = "O físico J. Robert Oppenheimer trabalha com uma equipe de cientistas durante o Projeto Manhattan, levando ao desenvolvimento da bomba atômica.", ImagemUrl = "https://br.web.img2.acsta.net/pictures/23/05/08/10/29/0695770.jpg" },
            new Filme { Id = 2, Titulo = "Barbie", Descricao = "Depois de ser expulsa da Barbieland por ser uma boneca de aparência menos do que perfeita, Barbie parte para o mundo humano em busca da verdadeira felicidade.", ImagemUrl = "https://m.media-amazon.com/images/M/MV5BNjU3N2QxNzYtMjk1NC00MTc4LTk1NTQtMmUxNTljM2I0NDA5XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_.jpg" },
            new Filme { Id = 3, Titulo = "Anatomia de uma Queda", Descricao = "Durante o último ano, Sandra, uma escritora alemã, e Samuel, seu marido francês, viveram juntos com Daniel, o filho de 11 anos do casal, em uma pequena e isolada cidade nos Alpes. Quando Samuel é encontrado morto, a polícia passa a tratar o caso como um suposto homicídio, e Sandra se torna a principal suspeita.", ImagemUrl = "https://br.web.img3.acsta.net/c_310_420/pictures/23/12/19/14/31/0947044.png" },
            new Filme { Id = 4, Titulo = "Pobres Criaturas", Descricao = "A jovem Bella Baxter é trazida de volta à vida pelo cientista Dr. Godwin Baxter. Querendo ver mais do mundo, ela foge com um advogado e viaja pelos continentes. Livre dos preconceitos de sua época, Bella exige igualdade e libertação.", ImagemUrl = "https://br.web.img3.acsta.net/pictures/23/09/02/05/42/2023019.png" },
            new Filme { Id = 5, Titulo = "Assasino da Lua das Flores", Descricao = "Os assassinatos dados a partir de circunstâncias misteriosas na década de 1920, assolando os membros da tribo Osage, acaba desencadeando uma grande investigação envolvendo o poderoso J. Edgar Hoover, considerado o primeiro diretor do FBI.", ImagemUrl = "https://br.web.img3.acsta.net/pictures/23/09/13/16/59/5541526.png" },
            new Filme { Id = 6, Titulo = "Ficção Americana", Descricao = "Monk é um escritor negro brilhante, mas seus livros não são populares já que ele se recusa a retratar negros de forma estereotipada em seu trabalho. Ele é pressionado por seu editor a criar uma obra comercial e escreve uma história carregada de preconceitos como piada.", ImagemUrl = "https://br.web.img3.acsta.net/pictures/24/02/28/14/55/0173785.png" },
            new Filme { Id = 7, Titulo = "Os rejeitados", Descricao = "Um professor rabugento, uma cozinheira de luto e um aluno inteligente e encrenqueiro são obrigados a passar o Natal juntos na escola e criam um vínculo inesperado.", ImagemUrl = "https://br.web.img3.acsta.net/pictures/24/01/09/19/08/4516319.jpg" },
            new Filme { Id = 8, Titulo = "Maestro", Descricao = "O maestro americano Leonard Bernstein se apaixona pela atriz costarriquenha Felicia Montealegre.", ImagemUrl = "https://upload.wikimedia.org/wikipedia/pt/1/1d/Maestro_2023.png" },
            new Filme { Id = 9, Titulo = "Vidas Passadas", Descricao = "Nora e Hae Sung, duas amigas de infância profundamente conectadas, se separam depois de uma mudança. Duas décadas depois, elas se reencontram na cidade de Nova York para uma semana fatídica enquanto confrontam noções de destino, amor e escolhas.", ImagemUrl = "https://br.web.img3.acsta.net/c_310_420/pictures/24/01/23/14/59/1144641.png" },
            new Filme { Id = 10, Titulo = "Zona de Interesse", Descricao = "Durante a Segunda Guerra Mundial, o comandante de Auschwitz, Rudolf Höss, e sua esposa, Hedwig, se esforçam para construir uma vida idílica para sua família em uma casa vizinha ao campo de concentração.", ImagemUrl = "https://br.web.img2.acsta.net/c_310_420/pictures/24/02/06/19/01/1087741.png" }
        };

        public IEnumerable<Filme> GetAllFilmes()
        {
            return filmes;
        }

        public Filme GetFilmeById(int id)
        {
            return filmes.Find(planet => planet.Id == id) ?? throw new KeyNotFoundException($"Filme com ID {id} não encontrado.");
        }
    }
}
