using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int a, int b);
        int Subtrair(int a, int b);
        double Multiplicar(int a, int b);
        double Dividir(int a, int b);
    }
}