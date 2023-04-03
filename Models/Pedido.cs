using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models
{
    public class Pedido
    {
        [Key]
        public int PedidoID { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar una direccion")]
        public string Direccion { get; set; }

        [Range(1, 4)]
        public int CantidadMedallones { get; set; }
        public bool Lechuga { get; set; }
        public bool Tomate { get; set; }
        public bool Huevo { get; set; }
        public bool Queso { get; set; } 


    }
}
