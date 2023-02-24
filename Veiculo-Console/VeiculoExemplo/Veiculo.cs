namespace VeiculoExemplo
{
    public class Veiculo
    {
        public Veiculo(int id, string nome)
        {
            Id = id;
            Nome = nome;

        }

        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
