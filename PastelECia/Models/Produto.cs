using System;
using System.Collections.Generic;

namespace PastelECia.Models
{
    public class Produto
    {
        public Produto()
        {
            Nome = string.Empty;
            Valor = 0;
            Quantidade = 0;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal
        {
            get
            {
                return Math.Round(Convert.ToDecimal(Quantidade * Valor), 2);
            }
        }

        public List<Produto> Produtos()
        {
            var lst = new List<Produto>();

            var prod = new Produto();
            prod.Id = 1;
            prod.Nome = "Coxinha";
            prod.Valor = 2.30M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 2;
            prod.Nome = "Catupiry";
            prod.Valor = 2.50M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 3;
            prod.Nome = "Charuto";
            prod.Valor = 2.35M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 4;
            prod.Nome = "Salsicha";
            prod.Valor = 2.15M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 5;
            prod.Nome = "Bolinha";
            prod.Valor = 2.35M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 6;
            prod.Nome = "Pastel de Strogonoff";
            prod.Valor = 2.35M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 7;
            prod.Nome = "Pastel de Milho";
            prod.Valor = 2.30M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 8;
            prod.Nome = "Pastel de Carne";
            prod.Valor = 2.35M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 9;
            prod.Nome = "Pastel de Napolitano";
            prod.Valor = 2.35M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 10;
            prod.Nome = "Kibe de Carne";
            prod.Valor = 2.50M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 11;
            prod.Nome = "Kibe de Requeijão";
            prod.Valor = 2.50M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 12;
            prod.Nome = "Empada de Frango";
            prod.Valor = 2.20M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 13;
            prod.Nome = "Empada de Frango com Requeijão";
            prod.Valor = 2.40M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 14;
            prod.Nome = "Empada de Frango com Bacon";
            prod.Valor = 2.40M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 15;
            prod.Nome = "Empada de Frango com Palmito";
            prod.Valor = 2.40M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 16;
            prod.Nome = "Empada de Milho com Requeijão";
            prod.Valor = 2.30M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 17;
            prod.Nome = "Empada de Queijo";
            prod.Valor = 3.00M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 18;
            prod.Nome = "Pastel Assado";
            prod.Valor = 2.40M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 19;
            prod.Nome = "Tortinha";
            prod.Valor = 2.70M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 20;
            prod.Nome = "Esfirra de Carne";
            prod.Valor = 2.30M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 21;
            prod.Nome = "Esfirra de Frango";
            prod.Valor = 2.30M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 22;
            prod.Nome = "Joelho";
            prod.Valor = 2.35M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 23;
            prod.Nome = "Hot Dog";
            prod.Valor = 2.35M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 24;
            prod.Nome = "Hambúrguer 10 und";
            prod.Valor = 3.10M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 25;
            prod.Nome = "Torta G";
            prod.Valor = 3.50M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 26;
            prod.Nome = "Cento Congelado 100 und";
            prod.Valor = 54.90M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 27;
            prod.Nome = "Cento Frito 100 und";
            prod.Valor = 2.30M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 28;
            prod.Nome = "Coxinha Media";
            prod.Valor = 0.80M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 29;
            prod.Nome = "Bolinha Media";
            prod.Valor = 0.80M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 30;
            prod.Nome = "Empadinha Media";
            prod.Valor = 0.80M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 31;
            prod.Nome = "Kibinho Media";
            prod.Valor = 0.80M;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 32;
            prod.Nome = "Salgado Mini Copo (Coxinha, Bolinha) KG";
            prod.Valor = 20.00M;
            prod.Quantidade = 0;
            lst.Add(prod);

            return lst;
        }
    }
}
