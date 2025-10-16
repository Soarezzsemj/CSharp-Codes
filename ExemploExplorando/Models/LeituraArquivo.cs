using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    // tupla em metodo

    public class LeituraArquivo
    {
        public (bool sucesso, string[] linhas, int Leituralinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false,new  string[0], 0);

            }
        } 
    }
}
    
