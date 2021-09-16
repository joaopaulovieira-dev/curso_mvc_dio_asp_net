using System.Collections.Generic;

namespace curso_mvc_dio_asp_net.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}