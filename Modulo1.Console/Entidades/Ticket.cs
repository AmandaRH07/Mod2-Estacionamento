using Modulo1.Console.Entidades.Preco;

namespace Modulo1.Console.Entidades
{
	internal class Ticket
	{
		public long Id { get; set; }
		public Veiculo Veiculo { get; set; }
		public DateTime DataHoraEntrada { get; set; }
		public DateTime? DataHoraSaida { get; set; }
		public Usuario Usuario { get; set; }
		public decimal ValorTotal { get; set; }
		public string Observacao { get; set; }
		public StatusTicket StatusTicket { get; set; }

		public static Ticket NovoTicket(long id,
			Veiculo veiculo,
			DateTime dataHoraEntrada,
			Usuario usuario,
			string Observacao,
			StatusTicket statusTicket,
			decimal valorTotal = 0)
		{
			var ticket = new Ticket();
			ticket.Id = id;
			ticket.Veiculo = veiculo;
			ticket.DataHoraEntrada = dataHoraEntrada;
			ticket.Usuario = usuario;
			ticket.ValorTotal = valorTotal;
			ticket.Observacao = Observacao;
			ticket.StatusTicket = statusTicket;

			return ticket;
		}

		public static Ticket AtualizarTicket(Ticket ticket,
			DateTime? novaDataHoraSaida,
			string? novaObservacao,
			StatusTicket? novoStatusTicket)
		{
			if (novaDataHoraSaida.HasValue)
			{
				ticket.DataHoraSaida = novaDataHoraSaida;
				if (ticket.Veiculo.TipoVeiculo == TipoVeiculo.Moto)
				{
					var t = new ConfigurarValoresMoto();
					t.ConfiguraValores();
					ticket.ValorTotal = t.CalculaValor(ticket.DataHoraEntrada, novaDataHoraSaida.Value);
				}

				if (ticket.Veiculo.TipoVeiculo == TipoVeiculo.Carro)
				{
					var t = new ConfigurarValoresCarro();
					t.ConfiguraValores();
					ticket.ValorTotal = t.CalculaValor(ticket.DataHoraEntrada, novaDataHoraSaida.Value);
				}
			}

			if (novaObservacao is not null)
				ticket.Observacao = novaObservacao;

			if (novoStatusTicket.HasValue)
				ticket.StatusTicket = novoStatusTicket.Value;

			return ticket;

		}
	}
}
