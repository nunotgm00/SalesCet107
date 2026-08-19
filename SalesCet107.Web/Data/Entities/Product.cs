using System.ComponentModel.DataAnnotations;

namespace SalesCet107.Web.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [MaxLength(100, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Name { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Price { get; set; }

        [Display(Name = "Stock")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Stock { get; set; }

        [Display(Name = "Disponível")]
        public bool IsAvailable { get; set; }
    }
}
