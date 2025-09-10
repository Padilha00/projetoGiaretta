namespace Dev.Dominio.modelos
{
    public class Jogos : Base
    {
       
        public required string Genero { get; set; }
        public required string Descricao { get; set; }
        public required string Preco { get; set; }
    
    }
}