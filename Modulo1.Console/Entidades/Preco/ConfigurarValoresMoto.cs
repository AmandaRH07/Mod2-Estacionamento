namespace Modulo1.Console.Entidades.Preco
{
	internal class ConfigurarValoresMoto : Preco
	{
		public override void ConfiguraValores()
		{
			ValorDiaria = 15;
			ValorAdicionalHora = 0.5M;
			ValorPrimeiraHora = 7;
			ValorPernoite = 10;
		}
	}
}
