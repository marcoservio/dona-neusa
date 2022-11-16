using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastelECia.VO
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotal
        {
            get
            {
                return Quantidade * Valor;
            }
        }

        public Produto()
        {
            Nome = string.Empty;
            Valor = 0;
            Quantidade = 0;
        }

        public List<Produto> Produtos()
        {
            var lst = new List<Produto>();

            var prod = new Produto();
            prod.Nome = "Coxinha";
            prod.Valor = 2.30;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Catupiry";
            prod.Valor = 2.50;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Charuto";
            prod.Valor = 2.35;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Salsicha";
            prod.Valor = 2.15;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Bolinha";
            prod.Valor = 2.35;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Pastel de Strogonoff";
            prod.Valor = 2.35;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Pastel de Milho";
            prod.Valor = 2.30;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Pastel de Carne";
            prod.Valor = 2.35;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Pastel de Napolitano";
            prod.Valor = 2.35;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Kibe de Carne";
            prod.Valor = 2.50;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Kibe de Requeijão";
            prod.Valor = 2.50;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Empada de Frango";
            prod.Valor = 2.20;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Empada de Frango com Requeijão";
            prod.Valor = 2.40;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Empada de Frango com Bacon";
            prod.Valor = 2.40;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Empada de Frango com Palmito";
            prod.Valor = 2.40;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Empada de Milho com Requeijão";
            prod.Valor = 2.30;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Empada de Queijo";
            prod.Valor = 3.00;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Pastel Assado";
            prod.Valor = 2.40;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Tortinha";
            prod.Valor = 2.70;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Esfirra de Carne";
            prod.Valor = 2.30;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Esfirra de Frango";
            prod.Valor = 2.30;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Joelho";
            prod.Valor = 2.35;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Hot Dog";
            prod.Valor = 2.35;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Hambúrguer 10 und";
            prod.Valor = 3.10;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Torta G";
            prod.Valor = 3.50;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Cento Congelado 100 und";
            prod.Valor = 54.90;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Cento Frito 100 und";
            prod.Valor = 2.30;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Coxinha Media";
            prod.Valor = 0.80;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Bolinha Media";
            prod.Valor = 0.80;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Empadinha Media";
            prod.Valor = 0.80;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Kibinho Media";
            prod.Valor = 0.80;
            prod.Quantidade = 0;
            lst.Add(prod);

            prod = new Produto();
            prod.Nome = "Salgado Mini Copo (Coxinha, Bolinha) KG";
            prod.Valor = 20.00;
            prod.Quantidade = 0;
            lst.Add(prod);

            return lst;
        }
    }
}
