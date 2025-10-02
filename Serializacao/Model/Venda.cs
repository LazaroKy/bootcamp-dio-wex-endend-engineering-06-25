using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serializacao.Model
{
    public class Venda
    {

        public Venda(int id, string produto, decimal preco, DateTime data_venda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = data_venda;
        }
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Produto: {Produto}, Preço: {Preco}, DataVenda: {DataVenda}";
        }
    }
}