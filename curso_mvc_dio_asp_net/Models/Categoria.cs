using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace curso_mvc_dio_asp_net.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descri��o")]
        [Required(ErrorMessage = "O campo descri��o � obrigat�rio.")]
        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}