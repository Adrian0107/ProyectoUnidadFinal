using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2
{
    public partial class Form2 : Form
    {

        public delegate void AgregarCarroEventHandler(string Nombre);
        public event AgregarCarroEventHandler AgregarCarro;
        compra Compra = new compra();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                
                Compra.Cantidad = double.Parse(textBox2.Text);
                Compra.Producto = textBox1.Text;
                Compra.Precio = double.Parse(textBox3.Text);
                Compra.Total = Compra.Precio * Compra.Cantidad;
                dataGridView1.Rows.Add(Compra.Producto, Compra.Cantidad, Compra.Precio, Compra.Total);

            }
            catch
            {
                MessageBox.Show("Error en los datos capturados");
            }
            finally
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            button1.Enabled = true;
            button2.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            int x;
            double sub = 0;
            int cuantosrenglones = dataGridView1.Rows.Count;
            if (cuantosrenglones == 0)
            {
                MessageBox.Show("No hay articulos en el carrito");
                return;
            }
            for (x = 0; x <= cuantosrenglones - 1; x++)
            {
                sub = sub + Convert.ToDouble(dataGridView1[3, x].Value);
            }
            Compra.Iva = sub * 0.16;
            Compra.Total = sub + Compra.Iva;
            dataGridView1.Rows.Add("", "", "Total:", sub);
            dataGridView1.Rows.Add("", "", "IVA:", Compra.Total);
            button1.Enabled = false;

            button4.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int posicion = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(posicion);
                

            } 
            AgregarCarro += MetodoGestor;
        }
        public void MetodoGestor(string Nombre)
        {
            MessageBox.Show($"Estimado(a) {Compra.Nombre}: Se le notifica que el producto seleccionado se ha eliminado del carrito");
        }

    }
}

