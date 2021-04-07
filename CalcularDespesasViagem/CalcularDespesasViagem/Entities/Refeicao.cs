namespace CalcularDespesasViagem.Entities
{
    class Refeicao : Despesa
    {
        public double ValorMedioRefeicao { get; set; }        
        public int RefeicaoAoDia { get; set; }

        public Refeicao()
        {
        }
        public Refeicao(int dias, double valorMedioRefeicao, int refeicaoAoDia) : base(dias)
        {
            ValorMedioRefeicao = valorMedioRefeicao;
            RefeicaoAoDia = refeicaoAoDia;
        }

        public double DespesaRefeicao()
        {
            return (ValorMedioRefeicao * RefeicaoAoDia) * Dias;
        }
    }
}
