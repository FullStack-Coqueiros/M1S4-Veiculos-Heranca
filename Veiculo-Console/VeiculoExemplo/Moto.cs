namespace VeiculoExemplo
{
    public class Moto : Veiculo
    {
        public Moto(int id, string nome) : base(id, nome)
        {
        }

        public void ImprimirDados()
        {
            Console.WriteLine($"Id {Id} - Nome {Nome}");
        }
    }
}
