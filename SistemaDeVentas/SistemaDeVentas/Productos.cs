using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
    [Serializable]
    internal class Productos:IComparable
    {
        public long Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public DateTime FechaCompra { get; set; }
        public string Categoria { get; set; }
        public string Proveedor { get; set; }
        public string Estado { get; set; }
        public int Cantidad { get; set; }
        
        public int Stock {  get; set; }
        public double TotalPagar { get; set; }

        public Productos(string nombre,double precio,long codigo,string categoria,string proveedor,string estado,DateTime fechaCompra,int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Codigo = codigo;
            Categoria = categoria;
            Proveedor = proveedor;
            Estado = estado;
            FechaCompra = fechaCompra;
            Stock = stock;
        }

        public double CalcularPrecio()
        {
            return Precio * Cantidad;
        }

        public int CompareTo(Object obj)
        {
            return this.Codigo.CompareTo(((Productos)obj).Codigo);
        }

        public override string ToString()
        {
            return Nombre + "- " + "$" + Precio + "- " + Codigo;
        }
    }
}
