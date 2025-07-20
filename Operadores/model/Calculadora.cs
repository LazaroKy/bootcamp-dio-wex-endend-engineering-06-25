using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Operadores aritmemétricos
// + - * / % ++ --
//Operações da lb Math
namespace Operadores.model
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y}= {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y}= {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y}= {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y}= {x / y}");
        }

        public void subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y}= {x - y}");
        }

        public void IncrementarUm(int x)
        {
            Console.WriteLine($"++{x}= {++x}");
        }

        public void DecrementarUm(int x)
        {
            Console.WriteLine($"--{x}= {--x}");
        }

        public void RestoDaDivisão(int x, int y)
        {
            Console.WriteLine($"{x} % {y}= {x % y}");
        }

        public void Potencia(int baseDaPotencia, int expoente)
        {
            double potencia = Math.Pow(baseDaPotencia, expoente);
            Console.WriteLine($"{baseDaPotencia}^{expoente} = {potencia}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {radiano} = {Math.Round(seno, 4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {radiano} = {Math.Round(coseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Coseno de {radiano} = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raizQuadrada = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {x}");
        }
    }
}