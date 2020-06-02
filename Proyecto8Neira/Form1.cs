using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto8Neira
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Tienda> tiendas = new List<Tienda>();
        public List<Cine> cines = new List<Cine>();
        public List<Recreacional> recreacional = new List<Recreacional>();
        public List<Restoran> restoran = new List<Restoran>();

        private void Form1_Load(object sender, EventArgs e)
        {
            controladorTiendas1.Hide();
            controlador.Hide();
            labelAlto.Show();
        }
        private void Revisar_Click(object sender, EventArgs e)
        {
            controladorTiendas1.Show();
        }

        private void ListadeObjetos_Click(object sender, EventArgs e)
        {

        }

        private void Mas_Click(object sender, EventArgs e)
        {
            controlador.Show();
            controlador.tiendas1 = tiendas;
            controlador.cines1 = cines;
            controlador.restoran1 = restoran;
            controlador.recreacional1 = recreacional;

        }

        private void Controlador_Load(object sender, EventArgs e)
        {

        }

        private void labelAlto_Click(object sender, EventArgs e)
        {

        }
    }
}
