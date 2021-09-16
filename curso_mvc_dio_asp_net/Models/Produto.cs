namespace curso_mvc_dio_asp_net.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descrição { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}