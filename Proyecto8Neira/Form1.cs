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
        int c = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (c == 0)
            {
                Cine c1 = new Cine("Cinemark", "Cristobal", "9998889099", "09:00", "14:00", "Accion", "50 comunes");
                Listas.cines.Add(c1);
                Cine c2 = new Cine("Cinemundo", "Cristobal", "1241204120399", "09:00", "14:00", "Accion", "30 comunes");
                Listas.cines.Add(c2);
                Cine c3 = new Cine("Planetmovies", "Cristobal", "7903114059", "09:00", "14:00", "Infantil", "50 comunes");
                Listas.cines.Add(c3);
                Cine c4 = new Cine("Movieplace", "Cristobal", "9998889099", "09:00", "14:00", "Adulto", "50 comunes");
                Listas.cines.Add(c4);
                Cine c5 = new Cine("CineCenter", "Cristobal", "9998889099", "09:00", "14:00", "Accion", "30 comunes");
                Listas.cines.Add(c5);
                //Restoran
                Restoran r1 = new Restoran("McDonalds", "Rocio", "666687099", "09:00", "14:00", "Comida Rapida", "5 comunes+1 exclusiva");
                Listas.restoranes.Add(r1);
                Restoran r2 = new Restoran("Le blanc", "Rocio", "897657099", "09:00", "14:00", "Gourmet", "5 comunes+1 exclusiva");
                Listas.restoranes.Add(r2);
                Restoran r3 = new Restoran("Papa pizza", "Rocio", "666687099", "09:00", "14:00", "Pizzeria", "5 comunes+1 exclusiva");
                Listas.restoranes.Add(r3);

                //Recreacional
                Recreacional rec1 = new Recreacional("Gladiadores", "Tomas", "333339099", "09:00", "14:00", "Gym", "Hombres");
                Listas.recreacionales.Add(rec1);
                Recreacional rec2 = new Recreacional("Mighty Yoga", "Tomas", "33356649099", "09:00", "14:00", "Yoga", "Mujeres");
                Listas.recreacionales.Add(rec2); 
                Recreacional rec3 = new Recreacional("Dragonslayers", "Tomas", "3233329099", "09:00", "14:00", "Muai-Thai", "Unisex");
                Listas.recreacionales.Add(rec3); 
                Recreacional rec4 = new Recreacional("The Box", "Tomas", "399999099", "09:00", "14:00", "Kick-Boxing", "Otros");
                Listas.recreacionales.Add(rec4);
                //Tienda
                Tienda t1 = new Tienda("GAPY", "Rene", "33344466677", "09;00", "14:00", "Ropa Infantil", "1");
                Listas.tiendas.Add(t1);
                Tienda t2 = new Tienda("Forever 98", "Rene", "55544466677", "09;00", "14:00", "Ropa Adulto", "2");
                Listas.tiendas.Add(t2);
                Tienda t3 = new Tienda("Hard", "Rene", "66644466677", "09;00", "14:00", "Hogar", "3");
                Listas.tiendas.Add(t3);
                Tienda t4 = new Tienda("Awesome", "Rene", "11144466677", "09;00", "14:00", "Jugetes", "1");
                Listas.tiendas.Add(t4);
                Tienda t5 = new Tienda("W-Forms", "Rene", "330004466677", "09;00", "14:00", "Electrodomestico", "3");
                Listas.tiendas.Add(t5);

                c += 1;

            }
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
            Form2 obj1 = new Form2();
            obj1.Show();
        }

        private void Mas_Click(object sender, EventArgs e)
        {
            controlador.Show();
        }

        private void Controlador_Load(object sender, EventArgs e)
        {

        }

        private void labelAlto_Click(object sender, EventArgs e)
        {

        }

        private void controladorTiendas1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void controlador_Load_1(object sender, EventArgs e)
        {

        }
    }
}
