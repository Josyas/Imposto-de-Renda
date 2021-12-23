using System;
using System.Collections.Generic;
using ImpostoDeRenda.Entities;

namespace ImpostoDeRenda.Entities
{
     abstract class Contribuintes
    {
        public string Nome { get;  set; }
        public double RendaAnual { get;  set; }

        protected Contribuintes(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();
    }
}
