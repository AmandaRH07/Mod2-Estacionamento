namespace Modulo1.Console.Entidades.Estacionamento
{
    internal class QuantidadeVagaCarro : Estacionamento
    {
        public override int AtualizarQuantidadeVagas(int qtdVagas)
        {
            return QuantidadeVagas = qtdVagas;
        }
    }
}
