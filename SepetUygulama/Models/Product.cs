using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SepetUygulama.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string PrintingArea { get; set; }
        public string PrintType { get; set; }

        //public string FilePath { get; set; }
        //public string FileName { get; set; }
    }
}
