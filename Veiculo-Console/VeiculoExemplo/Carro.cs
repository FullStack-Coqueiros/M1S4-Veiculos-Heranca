namespace VeiculoExemplo
{
    public class Carro : Veiculo 
    {
        public int Valor { get; set; }

        public Carro(int valor, int id, string nome) : base(id, nome)
        {
            this.Valor = valor;            
        }

        public void ImprimirDados()
        {
            Console.WriteLine($"Id {Id} - Nome {Nome} - Valor {Valor}");
        }
    }
}
