using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GhibliAPITest.Models
{
    public class Ghibli
    {
        public string id { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public string director { get; set; }

        public string producer { get; set; }

        public string release_date { get; set; }

        public int rt_score { get; set; }
    }
}