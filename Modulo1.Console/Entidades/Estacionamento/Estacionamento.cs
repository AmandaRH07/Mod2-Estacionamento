namespace Modulo1.Console.Entidades.Estacionamento
{
    internal abstract class Estacionamento
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public int QuantidadeVagas { get; set; }
        public string CNPJ { get; set; }

        public abstract int AtualizarQuantidadeVagas(int qtdVagas);
    }
}
