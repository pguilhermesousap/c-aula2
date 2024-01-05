using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Conta
    {
        public int Numero {  get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public long Senha { get; set; }
    public void ExibirInf()
    {
            Console.WriteLine($"\nTitular: {Titular}\nSaldo: {Saldo}\n");
    }

    }
}
