using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp.Models
{
    public class Promocao
    {
        public int Id { get; set; }
        public string Descricao { get; internal set; }
        public DateTime DataInicio { get; internal set; }
        public DateTime DataFim { get; internal set; }
        public List<PromocaoProduto> Produtos { get; internal set; }

        public Promocao() {
            Produtos = new List<PromocaoProduto>(); 
        }

        public void AddProduto(Produto produto) {
            Produtos.Add(new PromocaoProduto() { Produto = produto });
        }
    }
}
