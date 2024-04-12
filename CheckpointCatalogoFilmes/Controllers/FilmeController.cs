using CheckpointCatalagoFilmesClassLibrary.Repositories;
using CheckpointCatalogoFilmes.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheckpointCatalogoFilmes.Controllers
{
    public class FilmeController : Controller
    {
        private readonly FilmeRepository filmeRepository = new FilmeRepository();

        public IActionResult Index()
        {
            var filmes = filmeRepository.GetAllFilmes()
                .Select(filme => new FilmeViewModel
                {
                    Id = filme.Id,
                    ImagemUrl = filme.ImagemUrl,
                    Titulo = filme.Titulo
                });
            return View(filmes);
        }

        public IActionResult Details(int id)
        {

            // Retrieve the planet by its ID.
            var filme = filmeRepository.GetFilmeById(id);
            if (filme == null)
            {
                return NotFound();
            }

            // Map the planet to a view model.
            var viewModel = new FilmeViewModel
            {
                Id = filme.Id,
                Titulo = filme.Titulo,
                Descricao = filme.Descricao,
                ImagemUrl = filme.ImagemUrl
            };
            return View(viewModel);
        }
    }
}
