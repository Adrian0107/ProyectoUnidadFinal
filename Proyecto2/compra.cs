using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
	
    class compra
    {
		
		private string nombre="";

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private double cantidad;

		public double  Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}
		private string producto;

		public string Producto
		{
			get { return producto; }
			set { producto = value; }
		}
		private double precio;

		public double Precio
		{
			get { return precio; }
			set { precio = value; }
		}
		private double total;

		public double Total
		{
			get { return total; }
			set { total = value; }
		}
		private double iva;

		public double Iva
		{
			get { return iva; }
			set { iva = value; }
		}

		




	}
}
