using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto8Neira
{
    //Areglar diseño y ver si funciona
    public partial class Controlador : UserControl
    {

        public Controlador()
        {
            InitializeComponent();
        }
        public static List<Tienda> tiendas1 = Listas.tiendas;
        public static List<Cine> cines1 = Listas.cines;
        public static List<Recreacional> recreacionales1 = Listas.recreacionales;
        public static List<Restoran> restorans1 = Listas.restoranes;

        public void Controlador_Load(object sender, EventArgs e)
        {
            TipoLocalList.Items.Add("Tienda");
            TipoLocalList.Items.Add("Restoran");
            TipoLocalList.Items.Add("Cine");
            TipoLocalList.Items.Add("Recreacional");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label12.Hide();
        }
        int a = 0;
        public void AgregarL_Click(object sender, EventArgs e)
        {
            a += 1;
            if (a % 2 != 0)
            {
                label12.Hide();
                label10.Show();
                label11.Show();
            }
            else
            {
                label12.Show();
                label10.Hide();
                label11.Hide();
                TipoLocalList.ResetText();
                CategoriasList.ResetText();
                CaracteristicasList.ResetText();
            }
            string tipolocal = (string)TipoLocalList.SelectedItem;
            string categoria = (string)CategoriasList.SelectedItem;
            string caracteristica = (string)CaracteristicasList.SelectedItem;

            if (tipolocal == "Tienda" && a%2==0)
            {
                Tienda t1 = new Tienda(Nombre_Local.Text.ToString(), Nombre_Dueño.Text.ToString(),
                    Numero_Indicador.Text.ToString(), Apertura.Text.ToString(), Cierre.Text.ToString(),
                    categoria, caracteristica);
                Listas.tiendas.Add(t1);
                Nombre_Local.Clear();
                Nombre_Dueño.Clear();
                Numero_Indicador.Clear();
                Apertura.Clear();
                Cierre.Clear();
                TipoLocalList.Items.Clear();
                CategoriasList.Items.Clear();
                CaracteristicasList.Items.Clear();

                TipoLocalList.Items.Add("Tienda");
                TipoLocalList.Items.Add("Restoran");
                TipoLocalList.Items.Add("Cine");
                TipoLocalList.Items.Add("Recreacional");


            }
            else if (tipolocal == "Cine" && a % 2 == 0)
            {
                Cine t1 = new Cine(Nombre_Local.Text.ToString(), Nombre_Dueño.Text.ToString(),
                    Numero_Indicador.Text.ToString(), Apertura.Text.ToString(), Cierre.Text.ToString(), categoria, caracteristica);
                Listas.cines.Add(t1);
                Nombre_Local.Clear();
                Nombre_Dueño.Clear();
                Numero_Indicador.Clear();
                Apertura.Clear();
                Cierre.Clear();
                TipoLocalList.Items.Clear();
                CategoriasList.Items.Clear();
                CaracteristicasList.Items.Clear();
                TipoLocalList.Items.Add("Tienda");
                TipoLocalList.Items.Add("Restoran");
                TipoLocalList.Items.Add("Cine");
                TipoLocalList.Items.Add("Recreacional");

            }
            else if (tipolocal == "Recreacional" && a % 2 == 0)
            {
                Recreacional t1 = new Recreacional(Nombre_Local.Text.ToString(), Nombre_Dueño.Text.ToString(),
                    Numero_Indicador.Text.ToString(), Apertura.Text.ToString(), Cierre.Text.ToString(), categoria, caracteristica);
                Listas.recreacionales.Add(t1);
                Nombre_Local.Clear();
                Nombre_Dueño.Clear();
                Numero_Indicador.Clear();
                Apertura.Clear();
                Cierre.Clear();
                TipoLocalList.Items.Clear();
                CategoriasList.Items.Clear();
                CaracteristicasList.Items.Clear();
                TipoLocalList.Items.Add("Tienda");
                TipoLocalList.Items.Add("Restoran");
                TipoLocalList.Items.Add("Cine");
                TipoLocalList.Items.Add("Recreacional");
            }
            else if (tipolocal == "Restoran" && a % 2 == 0)
            {
                Restoran t1 = new Restoran(Nombre_Local.Text.ToString(), Nombre_Dueño.Text.ToString(),
                    Numero_Indicador.Text.ToString(), Apertura.Text.ToString(), Cierre.Text.ToString(), categoria, caracteristica);
                Listas.restoranes.Add(t1);
                Nombre_Local.Clear();
                Nombre_Dueño.Clear();
                Numero_Indicador.Clear();
                Apertura.Clear();
                Cierre.Clear();
                TipoLocalList.ResetText();
                TipoLocalList.ResetText();
                TipoLocalList.Items.Clear();
                CategoriasList.Items.Clear();
                CaracteristicasList.Items.Clear();
                TipoLocalList.Items.Add("Tienda");
                TipoLocalList.Items.Add("Restoran");
                TipoLocalList.Items.Add("Cine");
                TipoLocalList.Items.Add("Recreacional");
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string categoria = (string)TipoLocalList.SelectedItem;
            if (categoria == "Tienda")
            {
                CategoriasList.ResetText();
                CaracteristicasList.ResetText();
                CategoriasList.Items.Clear();
                CategoriasList.Items.Add("Ropa Infantil");
                CategoriasList.Items.Add("Ropa Adulto");
                CategoriasList.Items.Add("Hogar");
                CategoriasList.Items.Add("Jugetes");
                CategoriasList.Items.Add("Electrodomestico");
                label9.Left = 80;
                label9.Text = "Cajas:";
                CaracteristicasList.Items.Clear();
                CaracteristicasList.Items.Add("1");
                CaracteristicasList.Items.Add("2");
                CaracteristicasList.Items.Add("3");

            }
            else if (categoria == "Cine")
            {
                CategoriasList.ResetText();
                CaracteristicasList.ResetText();
                CategoriasList.Items.Clear();
                CategoriasList.Items.Add("Accion");
                CategoriasList.Items.Add("Infantil");
                CategoriasList.Items.Add("Adulto");
                label9.Left = 60;
                label9.Text = "Ascientos:";
                CaracteristicasList.Items.Clear();
                CaracteristicasList.Items.Add("30 comunes");
                CaracteristicasList.Items.Add("50 comunes");
                CaracteristicasList.Items.Add("20 comunes + 10 4D");
            }
            else if (categoria == "Restoran")
            {
                CategoriasList.ResetText();
                CaracteristicasList.ResetText();
                CategoriasList.Items.Clear();
                CategoriasList.Items.Add("Comida Rapida");
                CategoriasList.Items.Add("Gourmet");
                CategoriasList.Items.Add("Pizzeria");
                label9.Left = 80;
                label9.Text = "Mesas:";
                CaracteristicasList.Items.Clear();
                CaracteristicasList.Items.Add("5 comunes+1 exclusiva");
                CaracteristicasList.Items.Add("10 comunes+4 exclusivas");
                CaracteristicasList.Items.Add("20 comunes+1 exclusiva");
                CaracteristicasList.Items.Add("15 comunes+4 exclusivas");
            }
            else if (categoria == "Recreacional")
            {
                CategoriasList.ResetText();
                CaracteristicasList.ResetText();
                CategoriasList.Items.Clear();
                CategoriasList.Items.Add("Gym");
                CategoriasList.Items.Add("Yoga");
                CategoriasList.Items.Add("Kick-Boxing");
                CategoriasList.Items.Add("Muai-Thai");
                label9.Left = 80;
                label9.Text = "Clientes:";
                CaracteristicasList.Items.Clear();
                CaracteristicasList.Items.Add("Hombres");
                CaracteristicasList.Items.Add("Mujeres");
                CaracteristicasList.Items.Add("Unisex");
                CaracteristicasList.Items.Add("Otros");
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CaracteristicasList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
