namespace Modulo1.Console.Entidades
{
	internal class Endereco
	{
		public string Logradouro { get; set; }
		public string Numero { get; set; }
		public string Complemento { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Estado { get; set; }
		public string Cep { get; set; }

		public static Endereco NovoEndereco(string logradouro,
			string numero,
			string complemento,
			string bairro,
			string cidade,
			string estado,
			string cep)
		{
			var endereco = new Endereco();
			endereco.Logradouro = logradouro;
			endereco.Numero = numero;
			endereco.Complemento = complemento;
			endereco.Bairro = bairro;
			endereco.Cidade = cidade;
			endereco.Estado = estado;
			endereco.Cep = cep;
			return endereco;
		}

	}
}
