using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp.Models
{
    public class Produto
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double PrecoUnitario { get; internal set; }
        public string Unidade { get; internal set; }
        public List<PromocaoProduto> Promocoes { get; set; }

        public List<Pedido> Pedidos { get; set; }

    }
}