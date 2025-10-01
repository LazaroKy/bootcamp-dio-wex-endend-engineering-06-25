using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tupla.Models
{
    public class Objeto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Objeto(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

//Obrigatoriamente precisa ser deconstruct para desconstruir
        public void Deconstruct(out int id, out string nome)
        {
            id = Id;
            nome = Nome;
        }
    }
}