using GhibliAPITest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace GhibliAPITest.Controllers
{
    public class GhibliController : ApiController
    {
        [HttpGet]

        public IHttpActionResult GetFilmById(string id)
        {
            var service = new GhibliService();
            var film = service.GetFilmById(id);

            return Ok(film);
        }

        [HttpGet]
        public IHttpActionResult GetFilmByYear(string release_date)
        {
            var service = new GhibliService();
            var film = service.GetFilmByYear(release_date);

            return Ok(film);
        }

        [HttpGet]
        public IHttpActionResult GetAllFilms()
        {
            var service = new GhibliService();
            var list = service.GetAllFilms();

            return Ok(list);
        }

        [HttpGet]

        public IHttpActionResult Search(string term)
        {
            var service = new GhibliService();
            var filmsList = service.SearchFilms(term);

            return Ok(filmsList);
        }
    }
}