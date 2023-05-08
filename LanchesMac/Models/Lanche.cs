using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage ="O nome do lanche deve ser informado")]
        [Display(Name ="Nome do lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage ="O {0} deve ter no mínimo {1} e no máximo {2}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Uma descrição deve ser informado")]
        [Display(Name = "Nome do lanche")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]

        public int DescricaoCurta { get; set; }
        [Required(ErrorMessage = "Uma descrição deve ser informado")]
        [Display(Name = "Nome do lanche")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
        public string DescricaoDetalhada { get; set;}

        [Required(ErrorMessage = "Um preço deve ser informado")]
        [Display(Name ="Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99, ErrorMessage ="O preço deve estar entre 1 e 999,99")]
        public string Preco { get; set; }

        [Display(Name ="Caminho da Imagem")]
        [StringLength(220, ErrorMessage ="O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public string IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }


        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }


    }
}
