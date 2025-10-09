﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            Metodo2();
        }
        
        public void Metodo2()
        {
            Metodo3();
        }
        
        public void Metodo3()
        {
            try
            {
                Metodo4();
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("exceção tratada. " + ex.Message);
                
            }
        }
        
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção"); 
            // O throw ele faz com que o erro seja "jogado para cima" em busca de um catch para ter condição de tratar
            // a exception
       }
        
    }

}