using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SepetUygulama.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Date { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
