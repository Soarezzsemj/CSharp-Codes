using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{ 
    public class Vendas
    {
        public int Id { get; set; }
        
        [JsonProperty("Nome_Produto")] // Atributos
        // o atributo serve para se o json fugir do CamelCase vc colocar ele no CamelCase do c#
        public string Produto {get; set;}
        
        
        public decimal Preco {get; set;}
        
        public DateTime DataVenda {get; set;}
        
        
        
    }
}

