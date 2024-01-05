using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Produto
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        private double preco;
        private int estoque;
        public double Preco
        {
            get => preco;
            set
            {
                if(value>0) preco = value;
            }
        }
        public int Estoque
        {
            get => estoque;
            set
            {
                if (value > 0) estoque = value;
            }
        }
        public string ExibirInfo => $"Nome: {Nome}\nMarca: {Marca}\nPreço: R$ {Preco}\nEstoque: {Estoque}";
    }
}
