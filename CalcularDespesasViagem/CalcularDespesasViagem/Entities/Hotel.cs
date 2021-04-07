namespace CalcularDespesasViagem.Entities
{
    class Hotel : Despesa
    {
        public double ValorDiaria { get; set; }

        public Hotel()
        {
        }
        public Hotel(int dias, double valorDiaria) : base(dias)
        {
            ValorDiaria = valorDiaria;
        }

        public double DespesaHotel()
        {
            return ValorDiaria * Dias;
        }
    }
}
