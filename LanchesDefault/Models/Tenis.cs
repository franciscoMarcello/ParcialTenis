using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Models
{
    public class Tenis
    {
      
        private Tenis()
        {

        }
        public Tenis(string marca, string modelo, decimal valor)
        {
            Marca = marca;
            Modelo = modelo;
            Valor = valor;
        }

        public int Id { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public decimal Valor { get; private set; }

    }
}
