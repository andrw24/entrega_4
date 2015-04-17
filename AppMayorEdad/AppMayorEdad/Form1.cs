using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMayorEdad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona1 = new Persona(textBox1.Text,int.Parse(textBox2.Text));
            if (persona1.Edad >= 18)
            {
                MessageBox.Show(persona1.Nombre + " es mayor de edad");
            }
            else
            {
                MessageBox.Show(persona1.Nombre + " es menor de edad");
            }

        }
    }
}
