namespace CalcularDespesasViagem.Entities
{
    class Transporte
    {
        public double Quilometragem { get; set; }
        public double ValorCombustivel { get; set; }
        public double MediaConsumo { get; set; }
        public double ValorPedagios { get; set; }

        public Transporte()
        {
        }
        public Transporte(double quilometragem, double valorCombustivel, double mediaConsumo, double valorPedagios)
        {
            Quilometragem = quilometragem;
            ValorCombustivel = valorCombustivel;
            MediaConsumo = mediaConsumo;
            ValorPedagios = valorPedagios;
        }
        public double DespesaTransporte()
        {
            double combustivel = (Quilometragem / MediaConsumo) * ValorCombustivel;

            return combustivel + ValorPedagios;
        }
    }
}
