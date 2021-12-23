namespace ImpostoDeRenda.Entities
{
    class PessoaJuridica : Contribuintes
    {
        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroDeFuncionario) : base(nome, rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            NumeroDeFuncionarios = numeroDeFuncionario;
        }

        // regra de negocio
        public override double Imposto()
        {
            double total;
            if (NumeroDeFuncionarios <= 10)
            {
                total = RendaAnual * 0.16;
                return total;
            }
            else
            {
               total = RendaAnual * 0.14;
               return total;
            }
            return 0; 
        }

       

    }
}
