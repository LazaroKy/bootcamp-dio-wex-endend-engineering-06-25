using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tupla.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int NumeroDeLinhas) LerArquivo(string caminho_arquivo) {
            try
            {
                string[] linhas = File.ReadAllLines(caminho_arquivo);
                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false, [], 0);
            }
        }
    }
}