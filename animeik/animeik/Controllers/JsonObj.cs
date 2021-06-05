using System.Collections.Generic;

namespace animeik.Controllers
{
    public class Top
        {
            public int mal_id { get; set; }
            public int rank { get; set; }
            public string title { get; set; }
            public string url { get; set; }
            public string image_url { get; set; }
            public string type { get; set; }
            public int? episodes { get; set; }
            public string start_date { get; set; }
            public string end_date { get; set; }
            public int members { get; set; }
            public double score { get; set; }
        }

        public class JsonObj
        {
            public string request_hash { get; set; }
            public bool request_cached { get; set; }
            public int request_cache_expiry { get; set; }
            public List<Top> top { get; set; }
            public List<Top> results { get; set; }
        }
        
}