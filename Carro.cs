using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Carro
    {
        private int ano;
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public int Ano
        {
            get => ano;
            set
            {
                if (value >= 1960 && value <= 2024)
                {
                    ano = value;
                }
            }
        }        
        public string DescricaoDetalhada => $"Fabricante: {Fabricante}\nModelo: {Modelo}\nAno: {Ano}";
        public void acelerar()
        {
            Console.WriteLine("Acelerar");
        }
        public void frear()
        {
            Console.WriteLine("Frear");
        }
        public void buzinar() 
        {
            Console.WriteLine("Bibi");
        }
    }
}
