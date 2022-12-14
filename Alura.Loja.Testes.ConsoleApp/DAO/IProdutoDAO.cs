using Alura.Loja.Testes.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp.DAO
{
    interface IProdutoDAO
    {
        void Adicionar(Produto p);

        IList<Produto> Buscar();

        void Atualizar(Produto p);

        void Deletar(Produto p);

    }
}
