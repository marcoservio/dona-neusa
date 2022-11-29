using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static PastelECia.Models.Enum.Enumerador;

namespace PastelECia.Models
{
    public class Produto : IModelo
    {
        public Produto()
        {
            Nome = string.Empty;
            Descricao = string.Empty;
            Valor = decimal.Zero;
            Quantidade = 0;
            Inativo = SimNao.N;
            DataAlteracao = DateTime.Now;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public int UnidadeMedidaId { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }
        public SimNao Inativo { get; set; }
        public DateTime DataAlteracao { get; set; }

        [NotMapped]
        public decimal ValorTotal
        {
            get
            {
                return Math.Round(Convert.ToDecimal(Quantidade * Valor), 2);
            }
        }

        public List<Produto> LstProdutos()
        {
            var lst = new List<Produto>();

            var prod = new Produto();
            prod.Id = 1;
            prod.Nome = "Coxinha";
            prod.Valor = 2.30M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 2;
            prod.Nome = "Catupiry";
            prod.Valor = 2.50M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 3;
            prod.Nome = "Charuto";
            prod.Valor = 2.35M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 4;
            prod.Nome = "Salsicha";
            prod.Valor = 2.15M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 5;
            prod.Nome = "Bolinha";
            prod.Valor = 2.35M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 6;
            prod.Nome = "Pastel de Strogonoff";
            prod.Valor = 2.35M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 7;
            prod.Nome = "Pastel de Milho";
            prod.Valor = 2.30M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 8;
            prod.Nome = "Pastel de Carne";
            prod.Valor = 2.35M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 9;
            prod.Nome = "Pastel de Napolitano";
            prod.Valor = 2.35M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 10;
            prod.Nome = "Kibe de Carne";
            prod.Valor = 2.50M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 11;
            prod.Nome = "Kibe de Requeijão";
            prod.Valor = 2.50M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 12;
            prod.Nome = "Empada de Frango";
            prod.Valor = 2.20M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 13;
            prod.Nome = "Empada de Frango com Requeijão";
            prod.Valor = 2.40M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 14;
            prod.Nome = "Empada de Frango com Bacon";
            prod.Valor = 2.40M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 15;
            prod.Nome = "Empada de Frango com Palmito";
            prod.Valor = 2.40M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 16;
            prod.Nome = "Empada de Milho com Requeijão";
            prod.Valor = 2.30M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 17;
            prod.Nome = "Empada de Queijo";
            prod.Valor = 3.00M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 18;
            prod.Nome = "Pastel Assado";
            prod.Valor = 2.40M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 19;
            prod.Nome = "Tortinha";
            prod.Valor = 2.70M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 20;
            prod.Nome = "Esfirra de Carne";
            prod.Valor = 2.30M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 21;
            prod.Nome = "Esfirra de Frango";
            prod.Valor = 2.30M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 22;
            prod.Nome = "Joelho";
            prod.Valor = 2.35M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 23;
            prod.Nome = "Hot Dog";
            prod.Valor = 2.35M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 24;
            prod.Nome = "Hambúrguer 10 und";
            prod.Valor = 3.10M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 25;
            prod.Nome = "Torta G";
            prod.Valor = 3.50M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 26;
            prod.Nome = "Cento Congelado 100 und";
            prod.Valor = 54.90M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 27;
            prod.Nome = "Cento Frito 100 und";
            prod.Valor = 59.90M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 28;
            prod.Nome = "Coxinha Media";
            prod.Valor = 0.80M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 29;
            prod.Nome = "Bolinha Media";
            prod.Valor = 0.80M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 30;
            prod.Nome = "Empadinha Media";
            prod.Valor = 0.80M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 31;
            prod.Nome = "Kibinho Media";
            prod.Valor = 0.80M;
            lst.Add(prod);

            prod = new Produto();
            prod.Id = 32;
            prod.Nome = "Salgado Mini Copo (Coxinha, Bolinha) KG";
            prod.Valor = 20.00M;
            lst.Add(prod);

            return lst;
        }
    }
}
