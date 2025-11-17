namespace Dev.Dominio.modelos
{
    public class Usuario : Base
    {

        public required string Email { get; set; }
        public required string Senha { get; set; }
        public required string Telefone { get; set; }
        public required string CPF { get; set; }

    }
}
