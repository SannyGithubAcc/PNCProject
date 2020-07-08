using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PNCDemoWebApi.Data.Models
{
    public class Supplier
    {
        public long SupplierId { get; set; }
        //public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        //public string Country { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}