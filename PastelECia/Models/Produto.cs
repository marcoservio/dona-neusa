using PastelECia.Dados;

using System;
using System.Collections.Generic;
using System.Linq;

namespace PastelECia.Models
{
    public class Produto
    {
        public Produto()
        {
            Nome_prd = string.Empty;
            Valor_prd = decimal.Zero ;
            Quantidade = 0;
        }

        public int Id { get; set; }
        public string Nome_prd { get; set; }
        public decimal Valor_prd { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal
        {
            get
            {
                return Math.Round(Convert.ToDecimal(Quantidade * Valor_prd), 2);
            }
        }

        public List<Produto> LstProdutos()
        {
            var lst = new List<Produto>();

            var prod = new Produto();
            prod.Id = 1;
            prod.Nome_prd = "Coxinha";
            prod.Valor_prd = 2.30M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 2;
            prod.Nome_prd = "Catupiry";
            prod.Valor_prd = 2.50M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 3;
            prod.Nome_prd = "Charuto";
            prod.Valor_prd = 2.35M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 4;
            prod.Nome_prd = "Salsicha";
            prod.Valor_prd = 2.15M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 5;
            prod.Nome_prd = "Bolinha";
            prod.Valor_prd = 2.35M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 6;
            prod.Nome_prd = "Pastel de Strogonoff";
            prod.Valor_prd = 2.35M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 7;
            prod.Nome_prd = "Pastel de Milho";
            prod.Valor_prd = 2.30M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 8;
            prod.Nome_prd = "Pastel de Carne";
            prod.Valor_prd = 2.35M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 9;
            prod.Nome_prd = "Pastel de Napolitano";
            prod.Valor_prd = 2.35M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 10;
            prod.Nome_prd = "Kibe de Carne";
            prod.Valor_prd = 2.50M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 11;
            prod.Nome_prd = "Kibe de Requeijão";
            prod.Valor_prd = 2.50M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 12;
            prod.Nome_prd = "Empada de Frango";
            prod.Valor_prd = 2.20M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 13;
            prod.Nome_prd = "Empada de Frango com Requeijão";
            prod.Valor_prd = 2.40M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 14;
            prod.Nome_prd = "Empada de Frango com Bacon";
            prod.Valor_prd = 2.40M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 15;
            prod.Nome_prd = "Empada de Frango com Palmito";
            prod.Valor_prd = 2.40M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 16;
            prod.Nome_prd = "Empada de Milho com Requeijão";
            prod.Valor_prd = 2.30M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 17;
            prod.Nome_prd = "Empada de Queijo";
            prod.Valor_prd = 3.00M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 18;
            prod.Nome_prd = "Pastel Assado";
            prod.Valor_prd = 2.40M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 19;
            prod.Nome_prd = "Tortinha";
            prod.Valor_prd = 2.70M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 20;
            prod.Nome_prd = "Esfirra de Carne";
            prod.Valor_prd = 2.30M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 21;
            prod.Nome_prd = "Esfirra de Frango";
            prod.Valor_prd = 2.30M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 22;
            prod.Nome_prd = "Joelho";
            prod.Valor_prd = 2.35M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 23;
            prod.Nome_prd = "Hot Dog";
            prod.Valor_prd = 2.35M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 24;
            prod.Nome_prd = "Hambúrguer 10 und";
            prod.Valor_prd = 3.10M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 25;
            prod.Nome_prd = "Torta G";
            prod.Valor_prd = 3.50M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 26;
            prod.Nome_prd = "Cento Congelado 100 und";
            prod.Valor_prd = 54.90M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 27;
            prod.Nome_prd = "Cento Frito 100 und";
            prod.Valor_prd = 2.30M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 28;
            prod.Nome_prd = "Coxinha Media";
            prod.Valor_prd = 0.80M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 29;
            prod.Nome_prd = "Bolinha Media";
            prod.Valor_prd = 0.80M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 30;
            prod.Nome_prd = "Empadinha Media";
            prod.Valor_prd = 0.80M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 31;
            prod.Nome_prd = "Kibinho Media";
            prod.Valor_prd = 0.80M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 32;
            prod.Nome_prd = "Salgado Mini Copo (Coxinha, Bolinha) KG";
            prod.Valor_prd = 20.00M;
            lst.Add(prod);

            return lst;
        }
    }
}
