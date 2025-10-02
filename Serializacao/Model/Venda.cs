using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json; //Preciso adicionar para usar o JsonProperty

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
        
        [JsonProperty("Nome_Produto")]  //Você definiu um nome na qual será serializado como nome da Propriedade, é como uma metadata
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Produto: {Produto}, Preço: {Preco}, DataVenda: {DataVenda}";
        }
    }
}