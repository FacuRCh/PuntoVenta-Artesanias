using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public Usuario IdUsuario { get; set; }
        public Proveedor IdProveedor { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido {get;set;}
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public decimal MontoTotal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
