using MultiApps.Models.Entities.Abstract;

namespace MultiApps.Models.Entidades
{
    internal class Produto : EntidadeBase
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }
    }


}
