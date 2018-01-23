using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GhibliAPITest.Models
{
    public class GhibliSearchResults
    {
        public List<Ghibli> results { get; set; }

        public string search_term { get; set; }

        public int total_films { get; set; }
    }
}