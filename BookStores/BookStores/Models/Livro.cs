using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStores.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ISBN { get; set; }
        public DateTime DataLancamento { get; set; }

    }
}