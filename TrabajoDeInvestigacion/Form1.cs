using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoDeInvestigacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AvionComercial_Click(object sender, EventArgs e)
        {
            AvionComercial avionComercial = new AvionComercial();
            avionComercial.Piloto   = "Tomas";
            avionComercial.Copiloto = "Fernando";
            avionComercial.Azafata = "Azafata1";
            avionComercial.Capacidad = 100;
            avionComercial.LineaAerea = "LineaAerea1";
            MessageBox.Show(avionComercial.Piloto);
            MessageBox.Show(avionComercial.Copiloto);
            MessageBox.Show(avionComercial.Azafata);
            MessageBox.Show(avionComercial.Capacidad.ToString());
            MessageBox.Show(avionComercial.LineaAerea);
        }
    }
}
