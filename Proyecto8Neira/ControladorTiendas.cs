using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto8Neira
{
    public partial class ControladorTiendas : UserControl
    {
        public ControladorTiendas()
        {
            InitializeComponent();
        }
        public List<Tienda> tiendas2;
        public List<Cine> cines2;
        public List<Recreacional> recreacional2;
        public List<Restoran> restoran2;
        private void ControladorTiendas_Load(object sender, EventArgs e)
        {
            TIPOLOCAL.Items.Add("Tienda");
            TIPOLOCAL.Items.Add("Restoran");
            TIPOLOCAL.Items.Add("Cine");
            TIPOLOCAL.Items.Add("Recreacional");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoria = (string)TIPOLOCAL.SelectedItem;
            if (categoria == "Tienda")
            {
                LOCAL.ResetText();
                LOCAL.Items.Clear();
                foreach (var item in tiendas2)
                {
                    LOCAL.Items.Add(item.Nombre);
                }
            }
            else if (categoria == "Cine") 
            {
                LOCAL.ResetText();
                LOCAL.Items.Clear();
                foreach (var item in cines2)
                {
                    LOCAL.Items.Add(item.Nombre);
                }
            }
            else if (categoria == "Recreacional") 
            {
                LOCAL.ResetText();
                LOCAL.Items.Clear();
                foreach (var item in recreacional2)
                {
                    LOCAL.Items.Add(item.Nombre);
                }
            }
            else if (categoria == "Restoran")
            {
                LOCAL.ResetText();
                LOCAL.Items.Clear();
                foreach (var item in restoran2)
                {
                    LOCAL.Items.Add(item.Nombre);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void LOCAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            string local = (string)LOCAL.SelectedItem;
            foreach (var item in collection)
            {

            }
            listBox1.Text="Nombre: "+
        }
    }
}
