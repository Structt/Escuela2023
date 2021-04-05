using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaArchivp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sexo;
            sexo = (string)(radioButton1.Checked ? "Masculino" : "Femenino");

            Form2 usuario = new Form2(sexo);
            usuario.ShowDialog();
        }
    }
}
