
namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lUsuario = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuusuario = new FontAwesome.Sharp.IconMenuItem();
            this.menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            this.submenuproducto = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrarventa = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetalleventa = new FontAwesome.Sharp.IconMenuItem();
            this.menucompras = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrarcompra = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetallecompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuacercade = new FontAwesome.Sharp.IconMenuItem();
            this.MenuTitulo = new System.Windows.Forms.Panel();
            this.btnminvent = new FontAwesome.Sharp.IconButton();
            this.btnmin = new FontAwesome.Sharp.IconButton();
            this.btnmaxvent = new FontAwesome.Sharp.IconButton();
            this.btncerrar = new FontAwesome.Sharp.IconButton();
            this.btnslide = new FontAwesome.Sharp.IconButton();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            this.MenuTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.BackColor = System.Drawing.Color.LightCyan;
            this.lUsuario.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuario.ForeColor = System.Drawing.Color.Black;
            this.lUsuario.Location = new System.Drawing.Point(62, 19);
            this.lUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(65, 19);
            this.lUsuario.TabIndex = 4;
            this.lUsuario.Text = "Usuario";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.LightCyan;
            this.lblusuario.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.Black;
            this.lblusuario.Location = new System.Drawing.Point(131, 19);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(81, 19);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "lblusuario";
            // 
            // contenedor
            // 
            this.contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenedor.Location = new System.Drawing.Point(250, 54);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1131, 596);
            this.contenedor.TabIndex = 6;
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.menu);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 580);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.ImageScalingSize = new System.Drawing.Size(10, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuario,
            this.menumantenedor,
            this.menuventas,
            this.menucompras,
            this.menuclientes,
            this.menuproveedores,
            this.menureportes,
            this.menuacercade});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(250, 650);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuusuario
            // 
            this.menuusuario.AutoSize = false;
            this.menuusuario.Icon = FontAwesome.Sharp.IconChar.UserPlus;
            this.menuusuario.IconColor = System.Drawing.Color.Black;
            this.menuusuario.IconSize = 23;
            this.menuusuario.Image = ((System.Drawing.Image)(resources.GetObject("menuusuario.Image")));
            this.menuusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuusuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuario.Name = "menuusuario";
            this.menuusuario.Size = new System.Drawing.Size(80, 69);
            this.menuusuario.Text = "Usuarios";
            this.menuusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuusuario.Click += new System.EventHandler(this.menuusuario_Click);
            // 
            // menumantenedor
            // 
            this.menumantenedor.AutoSize = false;
            this.menumantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenucategoria,
            this.submenuproducto});
            this.menumantenedor.Icon = FontAwesome.Sharp.IconChar.Cogs;
            this.menumantenedor.IconColor = System.Drawing.Color.Black;
            this.menumantenedor.IconSize = 23;
            this.menumantenedor.Image = ((System.Drawing.Image)(resources.GetObject("menumantenedor.Image")));
            this.menumantenedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menumantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumantenedor.Name = "menumantenedor";
            this.menumantenedor.Size = new System.Drawing.Size(80, 69);
            this.menumantenedor.Text = "Matenedor";
            this.menumantenedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menumantenedor.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // submenucategoria
            // 
            this.submenucategoria.Icon = FontAwesome.Sharp.IconChar.None;
            this.submenucategoria.IconColor = System.Drawing.Color.Black;
            this.submenucategoria.IconSize = 16;
            this.submenucategoria.Image = ((System.Drawing.Image)(resources.GetObject("submenucategoria.Image")));
            this.submenucategoria.Name = "submenucategoria";
            this.submenucategoria.Size = new System.Drawing.Size(125, 22);
            this.submenucategoria.Text = "Categoria";
            this.submenucategoria.Click += new System.EventHandler(this.submenucategoria_Click);
            // 
            // submenuproducto
            // 
            this.submenuproducto.Icon = FontAwesome.Sharp.IconChar.None;
            this.submenuproducto.IconColor = System.Drawing.Color.Black;
            this.submenuproducto.IconSize = 16;
            this.submenuproducto.Image = ((System.Drawing.Image)(resources.GetObject("submenuproducto.Image")));
            this.submenuproducto.Name = "submenuproducto";
            this.submenuproducto.Size = new System.Drawing.Size(125, 22);
            this.submenuproducto.Text = "Producto";
            this.submenuproducto.Click += new System.EventHandler(this.submenuproducto_Click);
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarventa,
            this.submenuverdetalleventa});
            this.menuventas.Icon = FontAwesome.Sharp.IconChar.Tags;
            this.menuventas.IconColor = System.Drawing.Color.Black;
            this.menuventas.IconSize = 23;
            this.menuventas.Image = ((System.Drawing.Image)(resources.GetObject("menuventas.Image")));
            this.menuventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(80, 69);
            this.menuventas.Text = "Ventas";
            this.menuventas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // submenuregistrarventa
            // 
            this.submenuregistrarventa.Icon = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarventa.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarventa.IconSize = 16;
            this.submenuregistrarventa.Image = ((System.Drawing.Image)(resources.GetObject("submenuregistrarventa.Image")));
            this.submenuregistrarventa.Name = "submenuregistrarventa";
            this.submenuregistrarventa.Size = new System.Drawing.Size(129, 22);
            this.submenuregistrarventa.Text = "Registrar";
            this.submenuregistrarventa.Click += new System.EventHandler(this.submenuregistrarventa_Click);
            // 
            // submenuverdetalleventa
            // 
            this.submenuverdetalleventa.Icon = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetalleventa.IconColor = System.Drawing.Color.Black;
            this.submenuverdetalleventa.IconSize = 16;
            this.submenuverdetalleventa.Image = ((System.Drawing.Image)(resources.GetObject("submenuverdetalleventa.Image")));
            this.submenuverdetalleventa.Name = "submenuverdetalleventa";
            this.submenuverdetalleventa.Size = new System.Drawing.Size(129, 22);
            this.submenuverdetalleventa.Text = "Ver Detalle";
            this.submenuverdetalleventa.Click += new System.EventHandler(this.submenuverdetalleventa_Click);
            // 
            // menucompras
            // 
            this.menucompras.AutoSize = false;
            this.menucompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarcompra,
            this.submenuverdetallecompra});
            this.menucompras.Icon = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.menucompras.IconColor = System.Drawing.Color.Black;
            this.menucompras.IconSize = 23;
            this.menucompras.Image = ((System.Drawing.Image)(resources.GetObject("menucompras.Image")));
            this.menucompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menucompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucompras.Name = "menucompras";
            this.menucompras.Size = new System.Drawing.Size(80, 69);
            this.menucompras.Text = "Compras";
            this.menucompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // submenuregistrarcompra
            // 
            this.submenuregistrarcompra.Icon = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarcompra.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarcompra.IconSize = 16;
            this.submenuregistrarcompra.Image = ((System.Drawing.Image)(resources.GetObject("submenuregistrarcompra.Image")));
            this.submenuregistrarcompra.Name = "submenuregistrarcompra";
            this.submenuregistrarcompra.Size = new System.Drawing.Size(129, 22);
            this.submenuregistrarcompra.Text = "Registrar";
            this.submenuregistrarcompra.Click += new System.EventHandler(this.submenuregistrarcompra_Click);
            // 
            // submenuverdetallecompra
            // 
            this.submenuverdetallecompra.Icon = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetallecompra.IconColor = System.Drawing.Color.Black;
            this.submenuverdetallecompra.IconSize = 16;
            this.submenuverdetallecompra.Image = ((System.Drawing.Image)(resources.GetObject("submenuverdetallecompra.Image")));
            this.submenuverdetallecompra.Name = "submenuverdetallecompra";
            this.submenuverdetallecompra.Size = new System.Drawing.Size(129, 22);
            this.submenuverdetallecompra.Text = "Ver Detalle";
            this.submenuverdetallecompra.Click += new System.EventHandler(this.submenuverdetallecompra_Click);
            // 
            // menuclientes
            // 
            this.menuclientes.AutoSize = false;
            this.menuclientes.Icon = FontAwesome.Sharp.IconChar.UniversalAccess;
            this.menuclientes.IconColor = System.Drawing.Color.Black;
            this.menuclientes.IconSize = 23;
            this.menuclientes.Image = ((System.Drawing.Image)(resources.GetObject("menuclientes.Image")));
            this.menuclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(80, 69);
            this.menuclientes.Text = "Clientes";
            this.menuclientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click);
            // 
            // menuproveedores
            // 
            this.menuproveedores.AutoSize = false;
            this.menuproveedores.Icon = FontAwesome.Sharp.IconChar.Barcode;
            this.menuproveedores.IconColor = System.Drawing.Color.Black;
            this.menuproveedores.IconSize = 23;
            this.menuproveedores.Image = ((System.Drawing.Image)(resources.GetObject("menuproveedores.Image")));
            this.menuproveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuproveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedores.Name = "menuproveedores";
            this.menuproveedores.Size = new System.Drawing.Size(89, 69);
            this.menuproveedores.Text = "Proveedores";
            this.menuproveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuproveedores.Click += new System.EventHandler(this.menuproveedores_Click);
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.Icon = FontAwesome.Sharp.IconChar.BarChart;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconSize = 23;
            this.menureportes.Image = ((System.Drawing.Image)(resources.GetObject("menureportes.Image")));
            this.menureportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(80, 69);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menureportes.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // menuacercade
            // 
            this.menuacercade.AutoSize = false;
            this.menuacercade.Icon = FontAwesome.Sharp.IconChar.InfoCircle;
            this.menuacercade.IconColor = System.Drawing.Color.Black;
            this.menuacercade.IconSize = 23;
            this.menuacercade.Image = ((System.Drawing.Image)(resources.GetObject("menuacercade.Image")));
            this.menuacercade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuacercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuacercade.Name = "menuacercade";
            this.menuacercade.Size = new System.Drawing.Size(80, 69);
            this.menuacercade.Text = "Acerca de";
            this.menuacercade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuacercade.Click += new System.EventHandler(this.menuacercade_Click);
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.Controls.Add(this.lblusuario);
            this.MenuTitulo.Controls.Add(this.lUsuario);
            this.MenuTitulo.Controls.Add(this.btnminvent);
            this.MenuTitulo.Controls.Add(this.btnmin);
            this.MenuTitulo.Controls.Add(this.btnmaxvent);
            this.MenuTitulo.Controls.Add(this.btncerrar);
            this.MenuTitulo.Controls.Add(this.btnslide);
            this.MenuTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTitulo.Location = new System.Drawing.Point(250, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.Size = new System.Drawing.Size(1131, 55);
            this.MenuTitulo.TabIndex = 8;
            // 
            // btnminvent
            // 
            this.btnminvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminvent.Icon = FontAwesome.Sharp.IconChar.SquareO;
            this.btnminvent.IconColor = System.Drawing.Color.Black;
            this.btnminvent.IconSize = 12;
            this.btnminvent.Image = ((System.Drawing.Image)(resources.GetObject("btnminvent.Image")));
            this.btnminvent.Location = new System.Drawing.Point(1063, 13);
            this.btnminvent.Name = "btnminvent";
            this.btnminvent.Size = new System.Drawing.Size(25, 25);
            this.btnminvent.TabIndex = 4;
            this.btnminvent.UseVisualStyleBackColor = true;
            this.btnminvent.Click += new System.EventHandler(this.btnminvent_Click);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.Icon = FontAwesome.Sharp.IconChar.Star;
            this.btnmin.IconColor = System.Drawing.Color.Black;
            this.btnmin.IconSize = 16;
            this.btnmin.Image = ((System.Drawing.Image)(resources.GetObject("btnmin.Image")));
            this.btnmin.Location = new System.Drawing.Point(1032, 13);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(25, 25);
            this.btnmin.TabIndex = 3;
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnmaxvent
            // 
            this.btnmaxvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaxvent.Icon = FontAwesome.Sharp.IconChar.Star;
            this.btnmaxvent.IconColor = System.Drawing.Color.Black;
            this.btnmaxvent.IconSize = 16;
            this.btnmaxvent.Image = ((System.Drawing.Image)(resources.GetObject("btnmaxvent.Image")));
            this.btnmaxvent.Location = new System.Drawing.Point(1063, 13);
            this.btnmaxvent.Name = "btnmaxvent";
            this.btnmaxvent.Size = new System.Drawing.Size(25, 25);
            this.btnmaxvent.TabIndex = 2;
            this.btnmaxvent.UseVisualStyleBackColor = true;
            this.btnmaxvent.Click += new System.EventHandler(this.btnmaxvent_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Icon = FontAwesome.Sharp.IconChar.Check;
            this.btncerrar.IconColor = System.Drawing.Color.Black;
            this.btncerrar.IconSize = 16;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(1094, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(25, 25);
            this.btncerrar.TabIndex = 1;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnslide
            // 
            this.btnslide.Icon = FontAwesome.Sharp.IconChar.Bars;
            this.btnslide.IconColor = System.Drawing.Color.Black;
            this.btnslide.IconSize = 35;
            this.btnslide.Image = ((System.Drawing.Image)(resources.GetObject("btnslide.Image")));
            this.btnslide.Location = new System.Drawing.Point(6, 3);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(45, 45);
            this.btnslide.TabIndex = 0;
            this.btnslide.UseVisualStyleBackColor = true;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 650);
            this.Controls.Add(this.MenuTitulo);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de Venta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.MenuTitulo.ResumeLayout(false);
            this.MenuTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MenuTitulo;
        private FontAwesome.Sharp.IconButton btnmin;
        private FontAwesome.Sharp.IconButton btnmaxvent;
        private FontAwesome.Sharp.IconButton btncerrar;
        private FontAwesome.Sharp.IconButton btnminvent;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuusuario;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private FontAwesome.Sharp.IconMenuItem submenucategoria;
        private FontAwesome.Sharp.IconMenuItem submenuproducto;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarventa;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarcompra;
        private FontAwesome.Sharp.IconMenuItem submenuverdetallecompra;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private FontAwesome.Sharp.IconButton btnslide;
    }
}

