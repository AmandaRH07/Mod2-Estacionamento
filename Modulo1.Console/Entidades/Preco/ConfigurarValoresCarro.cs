namespace Modulo1.Console.Entidades.Preco
{
	internal class ConfigurarValoresCarro : Preco
	{
		public override void ConfiguraValores()
		{
			ValorDiaria = 25;
			ValorAdicionalHora = 2M;
			ValorPrimeiraHora = 10;
			ValorPernoite = 15;
		}
	}
}
