using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Website.Models
{
    public class UserModel
    {
        public int User_id { get; set; }
        public string UserName { get; set; }
        public string User_Email { get; set; }

        public string User_image { get; set; }

        public string User_background_image { get; set; }
        public UserModel(int User_id, string UserName, string User_Email, string User_image,string User_background_image)
        {
            this.User_id = User_id;
            this.UserName = UserName;
            this.User_Email = User_Email;
            this.User_image = User_image;
            this.User_background_image = User_background_image;


        }
    }
}
