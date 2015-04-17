using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVomboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int cont = 0; cont <= 255; cont++)
            {
                comboBox1.Items.Add(cont.ToString());
                comboBox2.Items.Add(cont.ToString());
                comboBox3.Items.Add(cont.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rojo, verde, azul;
            rojo= int.Parse(comboBox1.Text);
            verde= int.Parse(comboBox2.Text);
            azul = int.Parse(comboBox3.Text);
            BackColor = Color.FromArgb(rojo,verde,azul);
        }
        
        
    }
}
