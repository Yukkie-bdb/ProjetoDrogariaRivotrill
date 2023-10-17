using System.ComponentModel;

namespace ProjetoDrogas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        [DisplayName("Preço")]
        public int Preco { get; set; }

        /**********************/
        [DisplayName("Categoria Do Remédio")]
        public Guid CategoriaId { get; set; }
        public Categoria? Categorias { get; set; }

        /**********************/



    }
}
