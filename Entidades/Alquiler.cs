using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alquiler
    {
        public int id { get; set; }
        public DateTime fechaEntrega  { get; set; }
        public DateTime fechaDevolucion { get; set; }
        public double totalPago { get; set; }
        public double deposito { get; set; }
        public string estado { get; set; }
        public Cliente cliente { get; set; }
        List<DetalleAlquiler> detalles { get; set; }
        public Envio envio { get; set; }
        public void CalcularDeposito()
        {
            deposito = totalPago * 0.3;
        }
        public void CalcularTotal()
        {
            foreach (var item in detalles)
            {
                totalPago += item.subTotal;
            }
            totalPago += envio.precio;
        }
    }
}
