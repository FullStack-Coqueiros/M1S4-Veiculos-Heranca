
// See https://aka.ms/new-console-template for more information
using VeiculoExemplo;

Console.WriteLine("Hello, World!");


Veiculo veiculo1 = new Veiculo(1, "exemplo");
//veiculo1.Id = 1;
//veiculo1.Nome = "Teste 1";

Veiculo veiculo2 = new Veiculo(2, "exemplo 2");
//veiculo2.Id = 2;
//veiculo2.Nome = "Teste 2";

Repositorio.InserirVeiculo(veiculo1);
Repositorio.InserirVeiculo(veiculo2);

//Instancia nova com alteração de um registro
//Simulação de algum tempo após a inserção dos dados
veiculo1 = new Veiculo(1, "ALTERADO PARA UM");

Repositorio.Alterar(veiculo1);

var listaAntesExcluir = Repositorio.Listar();

Repositorio.Remover(1);

var listaApoxExcluir = Repositorio.Listar();

Carro carro1 = new Carro(10, 1, "tipo do carro 1");
//carro1.Id = 1;
//carro1.Nome = "Carro um";

Carro carro2 = new Carro(15, 2, "tipo do carro 2");
//carro2.Id = 2;
//carro2.Nome = "Carro dois";

Repositorio.InserirCarro(carro1);
Repositorio.InserirCarro(carro2);


Repositorio.ImprimirCarro();



