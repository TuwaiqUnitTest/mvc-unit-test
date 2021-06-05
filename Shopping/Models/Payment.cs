using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    public class Payment
    {
        [Key]
        public int Payment_Id { get; set; }
        public Decimal Amount { get; set; }
        public String Type { get; set; }
        public virtual Customer customer { get; set; }
    }
}
