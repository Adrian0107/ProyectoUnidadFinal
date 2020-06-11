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
    public partial class Carrito : Form
    {

        public Carrito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int posicion = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(posicion);
            }
        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            
        }
        public void ejecutar(string producto, double cantidad, double precio)
        {
        dataGridView1.Rows.Add(producto, cantidad, precio);
        }
    }
}
