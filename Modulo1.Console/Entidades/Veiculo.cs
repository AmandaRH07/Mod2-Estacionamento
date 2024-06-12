namespace Modulo1.Console.Entidades
{
	internal class Veiculo
	{
		public int Id { get; set; }
		public string Placa { get; set; }
		public string? Modelo { get; set; }
		public string? Marca { get; set; }
		public TipoVeiculo TipoVeiculo { get; set; }
		public string? Cor { get; set; }

		public static Veiculo NovoVeiculo(int id,
			string Placa,
			string? modelo,
			string? marca,
			TipoVeiculo tipoVeiculo,
			string? cor)
		{
			var veiculo = new Veiculo();
			veiculo.Id = id;
			veiculo.Placa = Placa;
			veiculo.TipoVeiculo = tipoVeiculo;

			if (modelo.Any())
				veiculo.Modelo = modelo;

			if (marca.Any())
				veiculo.Marca = marca;

			if (cor.Any())
				veiculo.Cor = cor;

			return veiculo;
		}

		public void RemoverVeiculo(int id)
		{
			
		}
	}
}
