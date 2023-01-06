namespace Alura.MinimalAPI.Model
{
    public class Pessoa
    {
        public Pessoa()
        {
            Identificador = Guid.NewGuid();
        }
        public Guid Identificador { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
