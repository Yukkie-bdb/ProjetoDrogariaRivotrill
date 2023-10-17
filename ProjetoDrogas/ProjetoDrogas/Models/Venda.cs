using Humanizer;
using System.ComponentModel;

namespace ProjetoDrogas.Models
{
    public class Venda
    {
        public Guid VendaId { get; set; }
        public string Nota { get; set; }
        [DisplayName("Horário")]
        public DateTime Horario { get; set; }

        /**********************/
        [DisplayName("Cliente")]
        public Guid ClienteId { get; set; }
        public Cliente? Clientes { get; set; }

        /**********************/
    }
    
}
