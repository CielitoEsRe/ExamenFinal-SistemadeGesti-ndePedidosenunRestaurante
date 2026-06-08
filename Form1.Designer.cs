namespace ExamenFinal_SistemadeGestióndePedidosenunRestaurante
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.tabPlatoFuerte = new System.Windows.Forms.TabPage();
            this.tabBebida = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.tabPostre = new System.Windows.Forms.TabPage();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTipoCarne = new System.Windows.Forms.ComboBox();
            this.comboBoxAcomp = new System.Windows.Forms.ComboBox();
            this.buttonAgregarPlato = new System.Windows.Forms.Button();
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxAzucar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPorcion = new System.Windows.Forms.ComboBox();
            this.buttonAgregarPostre = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxVolumen = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxBebida = new System.Windows.Forms.ComboBox();
            this.buttonAgregarbebida = new System.Windows.Forms.Button();
            this.dataGridViewMostrarProd = new System.Windows.Forms.DataGridView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonMOstrarProductos = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewBuscar = new System.Windows.Forms.DataGridView();
            this.buttonIrTipo = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            this.tabPlatoFuerte.SuspendLayout();
            this.tabBebida.SuspendLayout();
            this.tabPostre.SuspendLayout();
            this.tabListado.SuspendLayout();
            this.tabBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRegistro);
            this.tabControl1.Controls.Add(this.tabPlatoFuerte);
            this.tabControl1.Controls.Add(this.tabBebida);
            this.tabControl1.Controls.Add(this.tabPostre);
            this.tabControl1.Controls.Add(this.tabListado);
            this.tabControl1.Controls.Add(this.tabBusqueda);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.buttonIrTipo);
            this.tabRegistro.Controls.Add(this.textBoxPrecio);
            this.tabRegistro.Controls.Add(this.comboBoxProducto);
            this.tabRegistro.Controls.Add(this.label4);
            this.tabRegistro.Controls.Add(this.label3);
            this.tabRegistro.Controls.Add(this.textBoxNomb);
            this.tabRegistro.Controls.Add(this.label2);
            this.tabRegistro.Controls.Add(this.textBoxCodigo);
            this.tabRegistro.Controls.Add(this.label1);
            this.tabRegistro.Location = new System.Drawing.Point(4, 25);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(768, 397);
            this.tabRegistro.TabIndex = 1;
            this.tabRegistro.Text = "Registro";
            this.tabRegistro.UseVisualStyleBackColor = true;
            // 
            // tabPlatoFuerte
            // 
            this.tabPlatoFuerte.Controls.Add(this.buttonAgregarPlato);
            this.tabPlatoFuerte.Controls.Add(this.comboBoxAcomp);
            this.tabPlatoFuerte.Controls.Add(this.comboBoxTipoCarne);
            this.tabPlatoFuerte.Controls.Add(this.label6);
            this.tabPlatoFuerte.Controls.Add(this.label5);
            this.tabPlatoFuerte.Location = new System.Drawing.Point(4, 25);
            this.tabPlatoFuerte.Name = "tabPlatoFuerte";
            this.tabPlatoFuerte.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlatoFuerte.Size = new System.Drawing.Size(768, 397);
            this.tabPlatoFuerte.TabIndex = 2;
            this.tabPlatoFuerte.Text = "Plato Fuerte";
            this.tabPlatoFuerte.UseVisualStyleBackColor = true;
            // 
            // tabBebida
            // 
            this.tabBebida.Controls.Add(this.buttonAgregarbebida);
            this.tabBebida.Controls.Add(this.comboBoxBebida);
            this.tabBebida.Controls.Add(this.label10);
            this.tabBebida.Controls.Add(this.textBoxVolumen);
            this.tabBebida.Controls.Add(this.label9);
            this.tabBebida.Location = new System.Drawing.Point(4, 25);
            this.tabBebida.Name = "tabBebida";
            this.tabBebida.Padding = new System.Windows.Forms.Padding(3);
            this.tabBebida.Size = new System.Drawing.Size(768, 397);
            this.tabBebida.TabIndex = 3;
            this.tabBebida.Text = "Bebida";
            this.tabBebida.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(89, 33);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(221, 22);
            this.textBoxCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // textBoxNomb
            // 
            this.textBoxNomb.Location = new System.Drawing.Point(89, 118);
            this.textBoxNomb.Name = "textBoxNomb";
            this.textBoxNomb.Size = new System.Drawing.Size(221, 22);
            this.textBoxNomb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio base:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Producto:";
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Items.AddRange(new object[] {
            "Bebida",
            "PlatoFuerte",
            "Postre"});
            this.comboBoxProducto.Location = new System.Drawing.Point(89, 280);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(263, 24);
            this.comboBoxProducto.TabIndex = 6;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(110, 210);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(221, 22);
            this.textBoxPrecio.TabIndex = 7;
            // 
            // tabPostre
            // 
            this.tabPostre.Controls.Add(this.buttonAgregarPostre);
            this.tabPostre.Controls.Add(this.comboBoxPorcion);
            this.tabPostre.Controls.Add(this.label8);
            this.tabPostre.Controls.Add(this.comboBoxAzucar);
            this.tabPostre.Controls.Add(this.label7);
            this.tabPostre.Location = new System.Drawing.Point(4, 25);
            this.tabPostre.Name = "tabPostre";
            this.tabPostre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPostre.Size = new System.Drawing.Size(768, 397);
            this.tabPostre.TabIndex = 4;
            this.tabPostre.Text = "Postre";
            this.tabPostre.UseVisualStyleBackColor = true;
            // 
            // tabListado
            // 
            this.tabListado.Controls.Add(this.buttonMOstrarProductos);
            this.tabListado.Controls.Add(this.labelTotal);
            this.tabListado.Controls.Add(this.dataGridViewMostrarProd);
            this.tabListado.Location = new System.Drawing.Point(4, 25);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(768, 397);
            this.tabListado.TabIndex = 5;
            this.tabListado.Text = "Listado";
            this.tabListado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo de carne:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Acompañamiento:";
            // 
            // comboBoxTipoCarne
            // 
            this.comboBoxTipoCarne.FormattingEnabled = true;
            this.comboBoxTipoCarne.Items.AddRange(new object[] {
            "Res",
            "Pollo",
            "Cerdo",
            "Pescado",
            "Vegetariano"});
            this.comboBoxTipoCarne.Location = new System.Drawing.Point(125, 46);
            this.comboBoxTipoCarne.Name = "comboBoxTipoCarne";
            this.comboBoxTipoCarne.Size = new System.Drawing.Size(198, 24);
            this.comboBoxTipoCarne.TabIndex = 2;
            // 
            // comboBoxAcomp
            // 
            this.comboBoxAcomp.FormattingEnabled = true;
            this.comboBoxAcomp.Items.AddRange(new object[] {
            "Arroz",
            "Ensalada",
            "Papas",
            "Sopa"});
            this.comboBoxAcomp.Location = new System.Drawing.Point(151, 131);
            this.comboBoxAcomp.Name = "comboBoxAcomp";
            this.comboBoxAcomp.Size = new System.Drawing.Size(172, 24);
            this.comboBoxAcomp.TabIndex = 3;
            // 
            // buttonAgregarPlato
            // 
            this.buttonAgregarPlato.Location = new System.Drawing.Point(125, 256);
            this.buttonAgregarPlato.Name = "buttonAgregarPlato";
            this.buttonAgregarPlato.Size = new System.Drawing.Size(111, 60);
            this.buttonAgregarPlato.TabIndex = 4;
            this.buttonAgregarPlato.Text = "Agregar Plato";
            this.buttonAgregarPlato.UseVisualStyleBackColor = true;
            this.buttonAgregarPlato.Click += new System.EventHandler(this.buttonAgregarPlato_Click);
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.Controls.Add(this.dataGridViewBuscar);
            this.tabBusqueda.Controls.Add(this.buttonBuscar);
            this.tabBusqueda.Controls.Add(this.textBoxBusqueda);
            this.tabBusqueda.Controls.Add(this.label12);
            this.tabBusqueda.Controls.Add(this.comboBoxBusqueda);
            this.tabBusqueda.Controls.Add(this.label11);
            this.tabBusqueda.Location = new System.Drawing.Point(4, 25);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusqueda.Size = new System.Drawing.Size(768, 397);
            this.tabBusqueda.TabIndex = 6;
            this.tabBusqueda.Text = "Busqueda";
            this.tabBusqueda.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Contiene azucar:";
            // 
            // comboBoxAzucar
            // 
            this.comboBoxAzucar.FormattingEnabled = true;
            this.comboBoxAzucar.Items.AddRange(new object[] {
            "sí",
            "no"});
            this.comboBoxAzucar.Location = new System.Drawing.Point(163, 36);
            this.comboBoxAzucar.Name = "comboBoxAzucar";
            this.comboBoxAzucar.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAzucar.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Porcion:";
            // 
            // comboBoxPorcion
            // 
            this.comboBoxPorcion.FormattingEnabled = true;
            this.comboBoxPorcion.Location = new System.Drawing.Point(127, 118);
            this.comboBoxPorcion.Name = "comboBoxPorcion";
            this.comboBoxPorcion.Size = new System.Drawing.Size(157, 24);
            this.comboBoxPorcion.TabIndex = 3;
            // 
            // buttonAgregarPostre
            // 
            this.buttonAgregarPostre.Location = new System.Drawing.Point(127, 215);
            this.buttonAgregarPostre.Name = "buttonAgregarPostre";
            this.buttonAgregarPostre.Size = new System.Drawing.Size(147, 59);
            this.buttonAgregarPostre.TabIndex = 4;
            this.buttonAgregarPostre.Text = "Agregar Postre";
            this.buttonAgregarPostre.UseVisualStyleBackColor = true;
            this.buttonAgregarPostre.Click += new System.EventHandler(this.buttonAgregarPostre_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Volumen ml";
            // 
            // textBoxVolumen
            // 
            this.textBoxVolumen.Location = new System.Drawing.Point(149, 46);
            this.textBoxVolumen.Name = "textBoxVolumen";
            this.textBoxVolumen.Size = new System.Drawing.Size(200, 22);
            this.textBoxVolumen.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tipo de bebida:";
            // 
            // comboBoxBebida
            // 
            this.comboBoxBebida.FormattingEnabled = true;
            this.comboBoxBebida.Items.AddRange(new object[] {
            "Refresco natural",
            "Agua",
            "Gaseosa"});
            this.comboBoxBebida.Location = new System.Drawing.Point(165, 142);
            this.comboBoxBebida.Name = "comboBoxBebida";
            this.comboBoxBebida.Size = new System.Drawing.Size(184, 24);
            this.comboBoxBebida.TabIndex = 3;
            // 
            // buttonAgregarbebida
            // 
            this.buttonAgregarbebida.Location = new System.Drawing.Point(129, 239);
            this.buttonAgregarbebida.Name = "buttonAgregarbebida";
            this.buttonAgregarbebida.Size = new System.Drawing.Size(134, 50);
            this.buttonAgregarbebida.TabIndex = 4;
            this.buttonAgregarbebida.Text = "Agregar Bebida";
            this.buttonAgregarbebida.UseVisualStyleBackColor = true;
            this.buttonAgregarbebida.Click += new System.EventHandler(this.buttonAgregarbebida_Click);
            // 
            // dataGridViewMostrarProd
            // 
            this.dataGridViewMostrarProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrarProd.Location = new System.Drawing.Point(56, 41);
            this.dataGridViewMostrarProd.Name = "dataGridViewMostrarProd";
            this.dataGridViewMostrarProd.RowHeadersWidth = 51;
            this.dataGridViewMostrarProd.RowTemplate.Height = 24;
            this.dataGridViewMostrarProd.Size = new System.Drawing.Size(404, 234);
            this.dataGridViewMostrarProd.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(548, 78);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(131, 16);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total de Productos:0";
            // 
            // buttonMOstrarProductos
            // 
            this.buttonMOstrarProductos.Location = new System.Drawing.Point(576, 188);
            this.buttonMOstrarProductos.Name = "buttonMOstrarProductos";
            this.buttonMOstrarProductos.Size = new System.Drawing.Size(103, 68);
            this.buttonMOstrarProductos.TabIndex = 2;
            this.buttonMOstrarProductos.Text = "Mostrar todos los productos";
            this.buttonMOstrarProductos.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Buscar por:";
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Tipo de producto"});
            this.comboBoxBusqueda.Location = new System.Drawing.Point(134, 44);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(192, 24);
            this.comboBoxBusqueda.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Texto:";
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(120, 130);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(213, 22);
            this.textBoxBusqueda.TabIndex = 3;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(233, 237);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(100, 44);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBuscar
            // 
            this.dataGridViewBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuscar.Location = new System.Drawing.Point(423, 44);
            this.dataGridViewBuscar.Name = "dataGridViewBuscar";
            this.dataGridViewBuscar.RowHeadersWidth = 51;
            this.dataGridViewBuscar.RowTemplate.Height = 24;
            this.dataGridViewBuscar.Size = new System.Drawing.Size(320, 284);
            this.dataGridViewBuscar.TabIndex = 5;
            // 
            // buttonIrTipo
            // 
            this.buttonIrTipo.Location = new System.Drawing.Point(495, 154);
            this.buttonIrTipo.Name = "buttonIrTipo";
            this.buttonIrTipo.Size = new System.Drawing.Size(110, 46);
            this.buttonIrTipo.TabIndex = 8;
            this.buttonIrTipo.Text = "Ir al producto seleccionado";
            this.buttonIrTipo.UseVisualStyleBackColor = true;
            this.buttonIrTipo.Click += new System.EventHandler(this.buttonIrTipo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabRegistro.ResumeLayout(false);
            this.tabRegistro.PerformLayout();
            this.tabPlatoFuerte.ResumeLayout(false);
            this.tabPlatoFuerte.PerformLayout();
            this.tabBebida.ResumeLayout(false);
            this.tabBebida.PerformLayout();
            this.tabPostre.ResumeLayout(false);
            this.tabPostre.PerformLayout();
            this.tabListado.ResumeLayout(false);
            this.tabListado.PerformLayout();
            this.tabBusqueda.ResumeLayout(false);
            this.tabBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.TabPage tabPlatoFuerte;
        private System.Windows.Forms.TabPage tabBebida;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.ComboBox comboBoxProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPostre;
        private System.Windows.Forms.TabPage tabListado;
        private System.Windows.Forms.Button buttonAgregarPlato;
        private System.Windows.Forms.ComboBox comboBoxAcomp;
        private System.Windows.Forms.ComboBox comboBoxTipoCarne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAgregarPostre;
        private System.Windows.Forms.ComboBox comboBoxPorcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxAzucar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabBusqueda;
        private System.Windows.Forms.Button buttonAgregarbebida;
        private System.Windows.Forms.ComboBox comboBoxBebida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxVolumen;
        private System.Windows.Forms.Button buttonMOstrarProductos;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridView dataGridViewMostrarProd;
        private System.Windows.Forms.Button buttonIrTipo;
        private System.Windows.Forms.DataGridView dataGridViewBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.Label label11;
    }
}

