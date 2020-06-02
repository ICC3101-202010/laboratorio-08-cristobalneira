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
    public partial class ListasLocales : Form
    {
        public ListasLocales()
        {
            InitializeComponent();
        }

        private void Atrasform2_Click(object sender, EventArgs e)
        {
            Close();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int a = 0;
            int ab = 0;
            int ac = 0;
            int ad = 0;

            foreach (var item in Listas.tiendas)
            {
                a += 1;
                listBox1.Items.Add(a + ". " + item.Nombre + " | " + item.categoria);
            }
            foreach (var item in Listas.restoranes)
            {
                ab += 1;
                listBox2.Items.Add(ab + ". " + item.Nombre + " | " + item.categoria);
            }
            foreach (var item in Listas.cines)
            {
                ac += 1;
                listBox3.Items.Add(ac + ". " + item.Nombre + " | " + item.categoria);
            }
            foreach (var item in Listas.recreacionales)
            {
                ad += 1;
                listBox4.Items.Add(ad + ". " + item.Nombre + " | " + item.categoria);
            }

        }
    }
}
