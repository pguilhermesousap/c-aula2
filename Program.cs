using ContaBancaria;
using System.ComponentModel;

Conta conta1 = new Conta();
conta1.Titular = "Paulo";
conta1.Saldo = 100.50;
//conta1.exibirInf();

Carro carro = new Carro();
//carro.buzinar();
//carro.acelerar();
carro.Ano = 1990;
//Console.WriteLine(carro.Ano);

Produto produto = new Produto();
produto.Nome = "vassoura";
produto.Marca = "pirata";
produto.Preco = -5.40;
produto.Estoque = -3;
Console.WriteLine(produto.ExibirInfo);