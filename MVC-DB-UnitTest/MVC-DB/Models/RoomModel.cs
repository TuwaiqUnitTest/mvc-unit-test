using System;
using System.ComponentModel.DataAnnotations;
namespace MVC_DB.Models
{
    public class RoomModel
    {

        public int Id { get; set; }

        public string avalibalty { get; set; }
        //[Required]
        public int roomNumber { get; set; }

        //
        public StudnetModel Studnet { get; set; }
        public int StudnetId { get; set; }
    }
}
