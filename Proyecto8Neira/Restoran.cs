using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto8Neira
{
    public class Restoran
    {
        public string Nombre;
        public string Nombre_Dueño;
        public string Numero_Indicador;
        public string horario_inicio;
        public string horario_final;
        public string categoria;
        public string caracteristica;
        public Restoran(string n, string nd, string ni, string hi, string hf, string categoriaa, string caracteristicaa)
        {
            this.Nombre = n;
            this.Nombre_Dueño = nd;
            this.Numero_Indicador = ni;
            this.horario_inicio = hi;
            this.horario_final = hf;
            this.categoria = categoriaa;
            this.caracteristica = caracteristicaa;
        }
    }
}
