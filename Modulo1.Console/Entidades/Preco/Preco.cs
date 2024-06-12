using Modulo1.Console.Entidades;

namespace Modulo1.Console.Entidades.Preco
{
    /*
     * Carro
     Primeira hora para carro - 10,00
     Até 6 horas adicionais - 2,00
     A partir de 7 horas até 24 - diaria - 25
     Tolerancia de 10 min (sem cobrança)
     Entre 11 min e 20 min - ultimo valor / 60 * minutos excedentes
     Pernoite (entre 21 e 9) - 15,00

    * Moto
    Primeira hora para moto - 7,00
    Até 6 horas adicionais - 0,50
    A partir de 7 horas até 24 - diaria - 15
    Tolerancia de 10 min (sem cobrança)
    Entre 11 min e 20 min - ultimo valor / 60 * minutos excedentes
    Pernoite (entre 21 e 9) - 10,00
     */

    internal abstract class Preco
    {
        public TipoVeiculo TipoVeiculo { get; set; }
        public decimal ValorPrimeiraHora { get; set; }
        public decimal ValorAdicionalHora { get; set; }
        public decimal ValorDiaria { get; set; }
        public decimal ValorPernoite { get; set; }

        public abstract void ConfiguraValores();

		public decimal CalculaValor(DateTime entrada, DateTime saida)
        {
            var tempoTotal = saida - entrada;
            var valorTotal = 0.0M;
            
			if (entrada.TimeOfDay >= new TimeSpan(21) && saida.TimeOfDay <= new TimeSpan(9))
                valorTotal = ValorPernoite;
            else if (tempoTotal.TotalHours >= 7 && tempoTotal.TotalHours <= 24)
                valorTotal = ValorDiaria;
            else
            {
                valorTotal = ValorPrimeiraHora;

                if (tempoTotal.TotalHours > 1.16 && tempoTotal.TotalHours < 1.33)
                {
                    var minutosTolerados = valorTotal / (decimal)(60 * tempoTotal.TotalMinutes);
                    valorTotal += minutosTolerados;
                }
                else if (tempoTotal.TotalHours > 1.33)
                    for (var i = 0; i < tempoTotal.Hours; i++)
                        valorTotal += ValorAdicionalHora;
            }

            return valorTotal;
        }
    }
}
