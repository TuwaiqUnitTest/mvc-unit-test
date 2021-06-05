using System;
using System.Text.RegularExpressions;

namespace MVC_DB.Models
{
    public class StudnetModel
    {

        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        //Validate Email
        public string _email
        {
            get
            {
                return email;
            }
            set
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(value);

                if (match.Success)
                    email = value;
                else
                    throw new Exception("Invalid Email Formate");
            }
        }
        
        public RoomModel Room { get; set; }

    }
}

