using System;

namespace ImpostoDeRenda.Entities
{
    class PessoaFisica : Contribuintes
    {
        public double DespesaSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double despesaSaude) : base(nome, rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            DespesaSaude = despesaSaude; 
        }

        // regra de negocio
        public override double Imposto()
        {
            double total, despesaSaude, tot;
            if (RendaAnual <= 20000)
            {
                total = RendaAnual * 0.15;
                return total;
            }
            else if (RendaAnual > 20000)
            {
                total = RendaAnual * 0.25;
                despesaSaude = DespesaSaude * 0.50;
                tot = total - despesaSaude;
                return tot;
            }
            return 0;
            
        }
        
              
              
        
    }
   
}
