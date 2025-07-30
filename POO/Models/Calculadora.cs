using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO.Interfaces;

namespace POO.Models
{
    public class Calculadora : ICalculadora
    {

        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public void Multiplicar(int a, int b)
        {
            return a * b;
        }

        public decimal Dividir(int a, int b)
        {
            return a / b;
        }
    }
}