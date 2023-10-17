using System.ComponentModel;

namespace ProjetoDrogas.Models
{
    public class ItemVenda
    {
        [DisplayName("Id Venda")]
        public Guid ItemVendaId { get; set; }

        /**********************/
        [DisplayName("Venda")]
        public Guid VendaId { get; set; }
        public Venda? Vendas { get; set; }

        /**********************/
        [DisplayName("Produto")]
        public Guid ProdutoId { get; set; }
        public Produto? Produtos { get; set; }

        /**********************/

        public int Quantidade { get; set; }
        [DisplayName("Preço")]
        public int Preco { get; set; }

        /**********************/



    }
}
