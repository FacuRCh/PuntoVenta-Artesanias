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
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);
            foreach (IconMenuItem iconMenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconMenu.Name);

                if(encontrado == false)
                {
                    iconMenu.Enabled = false;
                }
            }

            lblusuario.Text = usuarioActual.Nombre;
            anchoOriginalPanelPrincipal = contenedor.Width;
        }

        private void AbrirFormulario(IconMenuItem menu,Form formulario)
        {
            if(MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if(FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuusuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender,new frmUsuarios());
        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(submenucategoria, new frmCategoria());
        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(submenuproducto, new frmProducto());
        }

        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(submenuregistrarventa, new frmVentas());
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(submenuverdetalleventa, new frmDetalleVenta());
        }

        private void submenuregistrarcompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(submenuregistrarcompra, new frmCompras());
        }

        private void submenuverdetallecompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(submenuverdetallecompra, new frmDetalleCompra());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
        }


        private bool menuContraido = false;
        private int anchoOriginalPanelPrincipal;


        private void btnslide_Click(object sender, EventArgs e)
        {
            if (menuContraido)
            {
                MenuVertical.Width = 250;
                contenedor.Left += 180;
                contenedor.Width = anchoOriginalPanelPrincipal; // Restaura el ancho original del panel principal
            }
            else
            {
                MenuVertical.Width = 70;
                contenedor.Left -= 180;
                contenedor.Width = anchoOriginalPanelPrincipal + 180; // Aumenta el ancho del panel principal hacia la derecha
            }

            menuContraido = !menuContraido; // Cambia el estado del menú (contraído/expandido)
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaxvent_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnminvent.Visible = true;
            btnmaxvent.Visible = false;
        }

        private void btnminvent_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnminvent.Visible = false;
            btnmaxvent.Visible = true;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuacercade_Click(object sender, EventArgs e)
        {
            // Crear el mensaje con la información de tu empresa
            string mensaje = "Información de Mi Empresa:\n\n";
            mensaje += "Nombre de la Empresa: Mi Empresa S.A.\n";
            mensaje += "Descripción: Somos una empresa dedicada a...\n";
            mensaje += "Encargado: Juan Pérez\n";
            mensaje += "Correo de Contacto: juan.perez@miempresa.com\n";
            mensaje += "Teléfono de Contacto: +1234567890\n";

            // Mostrar el MessageBox
            MessageBox.Show(mensaje, "Acerca de Mi Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
