using Modulo1.Console.Entidades;
using Modulo1.Console.Entidades.Estacionamento;

Usuario usuarioEstatico = Usuario.NovoUsuario("123", "tg", "Thamirys", TipoUsuario.Admin);

Usuario usuarioFuncionario = Usuario.NovoUsuario("321", "jo", "João", TipoUsuario.Funcionario);
var estacionamento = new QuantidadeVagaCarro();
var estacionamentoVagas = estacionamento.AtualizarQuantidadeVagas(25);

Console.WriteLine("Insira o novo veiculo: "); 

Console.WriteLine("Id: ");
var idVeiculo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Placa: ");
var placa = Console.ReadLine();
Console.WriteLine("Modelo: ");
var modelo = Console.ReadLine();
Console.WriteLine("Marca: ");
var marca = Console.ReadLine();

Console.WriteLine("Tipo do veículo" +
	"\n1 - Moto " +
	"\n2 - Carro :"); 
var tipoVeiculoInteiro = Convert.ToInt32(Console.ReadLine());
TipoVeiculo tipoVeiculoEnum = (TipoVeiculo)tipoVeiculoInteiro;

Console.WriteLine("Cor: ");
var cor = Console.ReadLine();

var veiculo = Veiculo.NovoVeiculo(idVeiculo, placa, modelo, marca, tipoVeiculoEnum, cor);


Console.WriteLine("Insira um novo ticket: ");

Console.WriteLine("Id: ");
var idTicket = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Data Entrada: ");
DateTime dataEntrada = DateTime.Now;
DateTime.TryParse(Console.ReadLine(), out dataEntrada);

Console.WriteLine("Observação: ");
var observacao = Console.ReadLine();

Console.WriteLine("Status do ticket" +
	"\n0 - Aberto " +
	"\n1 - Pago " +
	"\n2 - Cancelado:");
var statusTicketInteiro = Convert.ToInt32(Console.ReadLine());
StatusTicket statusTicketEnum = (StatusTicket)statusTicketInteiro;

var ticket = Ticket.NovoTicket(idTicket, veiculo, dataEntrada, usuarioFuncionario, observacao, statusTicketEnum );

estacionamentoVagas = estacionamento.AtualizarQuantidadeVagas(estacionamentoVagas - 1);
Console.WriteLine($"Quantidade vagas: {estacionamentoVagas}");

Console.WriteLine("Atualizar ticket: ");

Console.WriteLine("Data Saida: ");
DateTime dataSaida = DateTime.Now;
DateTime.TryParse(Console.ReadLine(), out dataSaida);

Console.WriteLine("Observação: ");
var observacaoTicketAtualizado = Console.ReadLine();

Console.WriteLine("Status do ticket" +
	"\n0 - Aberto " +
	"\n1 - Pago " +
	"\n2 - Cancelado:");
var statusTicketInteiroAtualizado = Convert.ToInt32(Console.ReadLine());
StatusTicket statusTicketEnumAtualizado = (StatusTicket)statusTicketInteiroAtualizado;

var ticketAtualizado = Ticket.AtualizarTicket(ticket, dataSaida, observacaoTicketAtualizado, statusTicketEnumAtualizado );

Console.WriteLine($"Valor total pago:  {ticketAtualizado.ValorTotal}");

estacionamentoVagas = estacionamento.AtualizarQuantidadeVagas(estacionamentoVagas + 1);
Console.WriteLine($"Quantidade vagas: {estacionamentoVagas}");
Console.ReadLine();
