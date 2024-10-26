// Iniciando Agência:
Agencia agencia = new Agencia();

// Parte do cadastro de Destinos:
Console.WriteLine("Iniciando seu cadastro:");
Destino destino1 = new Destino("Ottawa", "Canadá", "1234", "Aproveite a temporada de inverno para patinar no gelo pelo Canal Rideau!!");
Destino destino2 = new Destino("Seul", "Coreia do Sul", "5678", "Venha para Seul, a cidade que não dorme! Conheça seus bares, restaurantes e karaokês!");
agencia.CadastrarDestino(destino1);
agencia.CadastrarDestino(destino2);

// Aqui exibe os destinos cadastrados:
Console.WriteLine("\nDestinos que foram cadastrados com sucesso:");
agencia.ListarDestinos();

// Inicialização do cadastro de Pacotes Turísticos:
Console.WriteLine("\nIniciando seu cadastro:");
PacoteTuristico pacote1 = new PacoteTuristico("12349", "Pacote de 7 dias para Ottawa por 15000", destino1, DateTime.Now.AddDays(30), DateTime.Now.AddDays(37), 3500m, 5, "Ottawa Tour");
PacoteTuristico pacote2 = new PacoteTuristico("56789", "Pacote de 5 dias para Seul por 20000", destino2, DateTime.Now.AddDays(60), DateTime.Now.AddDays(65), 4500m, 10, "Seul Tour");
agencia.CadastrarPacote(pacote1);
agencia.CadastrarPacote(pacote2);

// Exibição de pacotes cadastrados:
Console.WriteLine("\nPacotes cadastrados com sucesso:");
agencia.ListarPacotes();

// Cadastro de Clientes:
Console.WriteLine("\nIniciando seu cadastro:");
Cliente cliente1 = new Cliente("Raissa", 12345, 912345678);
Cliente cliente2 = new Cliente("Gimenes", 67890, 909876543);
agencia.CadastrarCliente(cliente1);
agencia.CadastrarCliente(cliente2);

// Aqui mostra os clientes cadastrados:
Console.WriteLine("\nClientes cadastrados:");
agencia.ListarClientes();

// Criação das reservas:
Console.WriteLine("\nIniciando suas reservas:");
agencia.ReservarPacote("12349", cliente1); // Utilizando o código do pacote para reservar
agencia.ReservarPacote("56789", cliente2); // Utilizando o código do pacote para reservar

// Reservas feitas:
Console.WriteLine("\nReservas feitas com sucesso:");
foreach (var reserva in agencia.Reservas) //percorer cada reserva
{
    Console.WriteLine(reserva.Detalhes());
}

// Cancelamento de Reserva:
if (agencia.Reservas.Count > 0) //Verificaçao se há reservas registradas na agencia antes de tentar cancelar
{
    Console.WriteLine("\nCancelando reserva de Raissa...");
    agencia.CancelarReserva(agencia.Reservas[0].Codigo); // Acesso ao código da reserva
}
else
{
    Console.WriteLine("Não há reservas para cancelar.");
}

// Exibição da reserva após o cancelamento:
Console.WriteLine("\nReservas após o cancelamento:");
foreach (var reserva in agencia.Reservas) //Percorrer a lista atualizada de reservas
{
    Console.WriteLine(reserva.Detalhes());
}

Console.WriteLine("\nPrograma finalizado.");
