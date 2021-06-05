using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Website.Models
{
    public class ArticlesModel
    {
        public int User_id { get; set; }

        public int Article_id { get; set; }

        public string Created_at { get; set; }

        public string Article_title { get; set; }


        public string Article_content { get; set; }

        public string Article_image { get; set; }

        public ArticlesModel(int User_id, int Article_id, string Created_at,string Article_title, string Article_content, string Article_image)
        {
            this.User_id = User_id;
            this.Article_id = Article_id;
            this.Created_at = Created_at;
            this.Article_title = Article_title;
            this.Article_content = Article_content;
            this.Article_image = Article_image;
        }



    }
}
