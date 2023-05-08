using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria       //Estas informações que estão entre [] servem para configurar algumas informações que são
        //obrigatórias
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength(100, ErrorMessage ="O Tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage ="Informe o nome da categoria")]
        [Display(Name ="Nome")]
        public string CategoriaNome { get;}
        [StringLength(200, ErrorMessage = "O Tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Descrição")]
        public string Descricao { get;}

        public List<Lanche> Lanches { get;}
    }
}
