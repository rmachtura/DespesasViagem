using System;
using System.Globalization;
using CalcularDespesasViagem.Entities;

namespace CalcularDespesasViagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Transporte transporte;
            Despesa despesa;
            Refeicao refeicao = new Refeicao();
            Hotel hotel = new Hotel();            

            Console.Write("Quilometragem total: ");
            double quilometragem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor do Combustível: ");
            double valorCombustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Média de km/litro: ");
            double mediaConsumo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor total pedágios: ");
            double valorPedagios = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            transporte = new Transporte(quilometragem, valorCombustivel, mediaConsumo, valorPedagios);
            Console.WriteLine();
            Console.Write("Quantidade de dias: ");
            int dias = int.Parse(Console.ReadLine());
            despesa = new Despesa(dias);
            Console.Write("Incluir Refeição (s/n)? ");
            char respostaRefeicao = char.Parse(Console.ReadLine());
            if (respostaRefeicao == 's')
            {
                Console.Write("Valor médio Refeição por refeição: ");
                double valorRefeicao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade de refeições por dia: ");
                int quantidadeRefeicao = int.Parse(Console.ReadLine());
                refeicao = new Refeicao(dias, valorRefeicao, quantidadeRefeicao);
            }
            Console.WriteLine();
            Console.Write("Incluir Hospedagem (s/n)? ");
            char respostaTransporte = char.Parse(Console.ReadLine());
            if (respostaTransporte == 's')
            {
                Console.Write("Valor Diária Hotel: ");
                double valorHotel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                hotel = new Hotel(dias, valorHotel);
            }
            Console.WriteLine();
            Console.WriteLine($"Despesas com transporte: {transporte.DespesaTransporte().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Despesas com Refeições: {refeicao.DespesaRefeicao().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Despesas com hotel: {hotel.DespesaHotel().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine($"Valor total da viagem: {despesa.CalculoFinal(transporte.DespesaTransporte(), refeicao.DespesaRefeicao(), hotel.DespesaHotel()).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
