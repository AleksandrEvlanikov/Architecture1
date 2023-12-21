using Architecture7WebSPA.Models;
using Microsoft.AspNetCore.Mvc;

namespace Architecture7WebSPA.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            List<FilmReview> employees = new List<FilmReview>();
            employees.Add(new FilmReview
            {
                Id = 1,
                Name = "Райан Гослинг",
                NameFilm = "Бегущий по лезвию 2049",
                MovieReview = "7/10"

            });
            employees.Add(new FilmReview
            {
                Id = 2,
                Name = "Райан Гослинг",
                NameFilm = "Драйв",
                MovieReview = "10/10"

            });
            employees.Add(new FilmReview
            {
                Id = 3,
                Name = "Райан Гослинг",
                NameFilm = "Барби",
                MovieReview = "9/10"

            });

            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.FilmGosling = employees;

            return View(homeViewModel);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Settings()
        {
            return View();
        }

        public IActionResult ArticleAboutFilmDrave()
        {
            return View();
        }

        public IActionResult ArticleAboutFilmBarbi()
        {
            return View();
        }
    }
}
