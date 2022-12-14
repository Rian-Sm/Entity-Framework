using Alura.Loja.Testes.ConsoleApp.Context;
using Alura.Loja.Testes.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp.DAO
{
    class ProdutoDAOEntity : IDisposable, IProdutoDAO 
    {
        private LojaContext context = new LojaContext();

        public ProdutoDAOEntity() {
            context = new LojaContext();
        }

        public void Dispose()
        {
        }

        public void Adicionar(Produto p)
        {
            context.Produtos.Add(p);
            context.SaveChanges();
        }

        public void Atualizar(Produto p)
        {
            IList<Produto> produtos = this.Buscar();

            Produto prod = produtos.FirstOrDefault<Produto>(produto => produto.Id == p.Id);

            if (prod == null) return;

                context.Produtos.Update(p);
                context.SaveChanges();
        }

        public IList<Produto> Buscar()
        {
            IList<Produto> produtos = context.Produtos.ToList();

            return produtos;
        }

        public void Deletar(Produto p)
        {
            IList<Produto> produtos = this.Buscar();

            Produto prod = produtos.FirstOrDefault<Produto>(produto => produto.Id == p.Id);

            if (prod == null) return;

                context.Produtos.Remove(p);
                context.SaveChanges();
        }

     
    }
}
