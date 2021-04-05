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
    public partial class Form2 : Form
    {

        string sexo_usuario;
        public Form2(string sexo)
        {
            InitializeComponent();
            sexo_usuario = sexo;
        }

        private void MostrarImagen()
        {
            if(sexo_usuario=="Masculino")
            {
                pictureBox1.Image = Properties.Resources.hombre;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.mujer;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tbsexo.Text += sexo_usuario;
            MostrarImagen();
            tbnombre.Focus();
            button1.Enabled = false;
        }


        private void Control()
        {
            if(tbnombre.Text.Trim()!=string.Empty && tbnombre.Text.All(char.IsLetter))
            {
                button1.Enabled = true;
                errorProvider1.SetError(tbnombre, "");
            }
            else
            {
                button1.Enabled = false;
                if(!tbnombre.Text.All(char.IsLetter))
                {
                    errorProvider1.SetError(tbnombre, "Solo caracteres");
                }
                else
                {
                    errorProvider1.SetError(tbnombre, "");
                }
            }
        }

        private void tbnombre_TextChanged(object sender, EventArgs e)
        {
            Control();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 saludo = new Form3(tbnombre.Text);
            saludo.ShowDialog();
        }
    }
}
