using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class ContaCorrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;   
        }
    }
}