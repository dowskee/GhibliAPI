using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GhibliAPITest.Models
{
    public class GhibliService
    {
        public const string baseUrl = "https://ghibliapi.herokuapp.com";

        public Ghibli GetFilmById(string id)
        {
            IRestClient client = new RestClient(baseUrl);

            var request = new RestRequest("films/{id}");

            request.AddUrlSegment("id", id);

            var response = client.Get<Ghibli>(request);

            return response.Data;
        }

        public Ghibli GetFilmByYear(string release_date)
        {
            IRestClient client = new RestClient(baseUrl);

            var request = new RestRequest("films/{release_date}");
            //all you need to add to local host url is /api/ghibli/{id} or {title} or whatever it may be
            request.AddUrlSegment("release_date", release_date);

            var response = client.Get<Ghibli>(request);

            return response.Data;
        }

        public List<Ghibli> GetAllFilms()
        {
            IRestClient client = new RestClient(baseUrl);

            var request = new RestRequest(Method.GET);
            //no key needed
            var response = client.Get<List<Ghibli>>(request);

            return response.Data;
        }

        public GhibliSearchResults SearchFilms(string term)
        {
            IRestClient client = new RestClient(baseUrl);

            var request = new RestRequest("search");

            request.AddQueryParameter("term", term);

            var response = client.Get<GhibliSearchResults>(request);

            return response.Data;
        }
    }
}