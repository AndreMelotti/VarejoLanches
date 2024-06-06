using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VarejoLanches.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LacheId { get; set; }

        [Required (ErrorMessage ="O nome do lanche deve ser Informado")]
        [Display(Name ="Nome do Lanche")]
        [StringLength (80, MinimumLength = 10, ErrorMessage ="O {0} deve ter no mínimo {1} e no máximo {2}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser Informado")]
        [Display(Name = "Descrição curta")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser Informado")]
        [Display(Name = "Descrição detalhada")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "o preço do lanche deve ser Informado")]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage ="O preço tem que estar entre 1 e 999,99")]
        public decimal Preco {  get; set; }

        [Display(Name = "Url da Imagem")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Url da Miniatura da Imagem")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get;  set; }


        
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
