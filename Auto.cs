using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Auto
    {
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public string Color { get; set; }

        public Auto(string matricula, string marca, string tipo, string color) {        
            Matricula = matricula;
            Marca = marca;
            Tipo = tipo;
            Color = color;
        }

        public void Avanzar() {
            Console.WriteLine("Mi {0} esta avanzando...",Marca);
        }

        public void Frenar()
        {
            Console.WriteLine("Mi {0} esta frenando...", Marca);
        }

        public void Estacionar()
        {
            Console.WriteLine("Estacione mi {0}...", Marca);
        }
    }
}
