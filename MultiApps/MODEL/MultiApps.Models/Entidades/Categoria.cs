using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiApps.Models.Entidades
{
    internal class Categoria
    {
        public int id { get; set; }
        public string nome { get; set; }
        public decimal Preco { get; set; }         
        public int QuantidadeEmEstoque { get; set; }
        public Categoria categoria { get; set; }
    }
}
