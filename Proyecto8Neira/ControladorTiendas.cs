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
            listBox1.Items.Clear();
            if (categoria == "Tienda")
            { 
                LOCAL.Items.Clear();
                foreach (var item in Listas.tiendas)
                {
                    LOCAL.Items.Add(item.Nombre);
                }
            }

            else if (categoria == "Cine") 
            {
                LOCAL.ResetText();
                LOCAL.Items.Clear();
                foreach (var item in Listas.cines)
                {
                    LOCAL.Items.Add(item.Nombre);
                }
            }

            else if (categoria == "Recreacional") 
            {
                LOCAL.ResetText();
                LOCAL.Items.Clear();
                foreach (var item in Listas.recreacionales)
                {
                    LOCAL.Items.Add(item.Nombre);
                }
            }

            else if (categoria == "Restoran")
            {
                LOCAL.ResetText();
                LOCAL.Items.Clear();
                foreach (var item in Listas.restoranes)
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
            string categoria = (string)TIPOLOCAL.SelectedItem;
            string local = (string)LOCAL.SelectedItem;
            listBox1.Items.Clear();
            if (categoria == "Tienda")
            {
                foreach (var item in Listas.tiendas)
                {
                    if (item.Nombre == local)
                    {

                        listBox1.Items.Add("Nombre: " + item.Nombre);
                        listBox1.Items.Add("Nombre_Dueño: " + item.Nombre_Dueño);
                        listBox1.Items.Add("Numero_Indicador: " + item.Numero_Indicador);
                        listBox1.Items.Add("Horario_Inicio: " + item.horario_inicio);
                        listBox1.Items.Add("Horario_Final: " + item.horario_final);
                        listBox1.Items.Add("Categoria: " + item.categoria);
                        listBox1.Items.Add("Cajeros: " + item.caracteristica);
                        break;
                    }
                }
            }
            else if (categoria == "Cine")
            {
                foreach (var item in Listas.cines)
                {
                    if (item.Nombre == local)
                    {

                        listBox1.Items.Add("Nombre: " + item.Nombre);
                        listBox1.Items.Add("Nombre_Dueño: " + item.Nombre_Dueño);
                        listBox1.Items.Add("Numero_Indicador: " + item.Numero_Indicador);
                        listBox1.Items.Add("Horario_Inicio: " + item.horario_inicio);
                        listBox1.Items.Add("Horario_Final: " + item.horario_final);
                        listBox1.Items.Add("Categoria: " + item.categoria);
                        listBox1.Items.Add("Ascientos: " + item.caracteristica);
                        break;
                    }
                }
            }
            else if (categoria == "Recreacional")
            {
                foreach (var item in Listas.recreacionales)
                {
                    if (item.Nombre == local)
                    {

                        listBox1.Items.Add("Nombre: " + item.Nombre);
                        listBox1.Items.Add("Nombre_Dueño: " + item.Nombre_Dueño);
                        listBox1.Items.Add("Numero_Indicador: " + item.Numero_Indicador);
                        listBox1.Items.Add("Horario_Inicio: " + item.horario_inicio);
                        listBox1.Items.Add("Horario_Final: " + item.horario_final);
                        listBox1.Items.Add("Categoria: " + item.categoria);
                        listBox1.Items.Add("Publico: " + item.caracteristica);
                        break;
                    }
                }
            }
            else if (categoria == "Restoran")
            {
                foreach (var item in Listas.restoranes)
                {
                    if (item.Nombre == local)
                    {

                        listBox1.Items.Add("Nombre: " + item.Nombre);
                        listBox1.Items.Add("Nombre_Dueño: " + item.Nombre_Dueño);
                        listBox1.Items.Add("Numero_Indicador: " + item.Numero_Indicador);
                        listBox1.Items.Add("Horario_Inicio: " + item.horario_inicio);
                        listBox1.Items.Add("Horario_Final: " + item.horario_final);
                        listBox1.Items.Add("Categoria: " + item.categoria);
                        listBox1.Items.Add("Mesas: " + item.caracteristica);
                        break;
                    }
                }
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
