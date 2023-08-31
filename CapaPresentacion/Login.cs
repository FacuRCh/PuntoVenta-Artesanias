using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();

            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtdocumento.Text && u.Clave == txtcontraseña.Text).FirstOrDefault();

            if(ousuario!= null)
            {
                MessageBox.Show("Bienvenido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Form1 sería el formulario de Inicio
                Form1 form = new Form1();
                form.Show();
                this.Hide();
                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontro el usuario ","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }

        private void frm_closing(Object sender, FormClosingEventArgs e)
        {
            txtdocumento.Text = "";
            txtcontraseña.Text = "";
            this.Show();
        }
    }


}
