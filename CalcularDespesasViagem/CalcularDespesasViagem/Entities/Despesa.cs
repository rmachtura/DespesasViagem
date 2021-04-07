namespace CalcularDespesasViagem.Entities
{
    class Despesa
    {
        public int Dias { get; set; }

        public Despesa()
        {

        }
        public Despesa(int dias)
        {
            Dias = dias;
        }

        public double CalculoFinal(double transporte, double refeicao, double hospedagem)
        {
            return transporte + refeicao + hospedagem;
        }
    }
}
