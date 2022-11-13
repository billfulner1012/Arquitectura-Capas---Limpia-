namespace capapresentacion
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.cbobuscar = new System.Windows.Forms.ComboBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnuevo = new System.Windows.Forms.Button();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbotipodocumento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtfechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbosexo = new System.Windows.Forms.ComboBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mensajetool = new System.Windows.Forms.ToolTip(this.components);
            this.iconoerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoerror)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(28, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 351);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btneliminar);
            this.tabPage1.Controls.Add(this.btnbuscar);
            this.tabPage1.Controls.Add(this.txtbuscar);
            this.tabPage1.Controls.Add(this.cbobuscar);
            this.tabPage1.Controls.Add(this.lbltotal);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.datalistado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(838, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(597, 33);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(497, 33);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(169, 33);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(312, 20);
            this.txtbuscar.TabIndex = 4;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // cbobuscar
            // 
            this.cbobuscar.FormattingEnabled = true;
            this.cbobuscar.Items.AddRange(new object[] {
            "NOMBRE",
            "APELLIDOS"});
            this.cbobuscar.Location = new System.Drawing.Point(32, 32);
            this.cbobuscar.Name = "cbobuscar";
            this.cbobuscar.Size = new System.Drawing.Size(121, 21);
            this.cbobuscar.TabIndex = 3;
            this.cbobuscar.Text = "NOMBRE";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(374, 78);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(35, 13);
            this.lbltotal.TabIndex = 2;
            this.lbltotal.Text = "label1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(32, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Eliminar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // datalistado
            // 
            this.datalistado.AllowUserToAddRows = false;
            this.datalistado.AllowUserToDeleteRows = false;
            this.datalistado.AllowUserToOrderColumns = true;
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datalistado.Location = new System.Drawing.Point(32, 113);
            this.datalistado.MultiSelect = false;
            this.datalistado.Name = "datalistado";
            this.datalistado.ReadOnly = true;
            this.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado.Size = new System.Drawing.Size(755, 193);
            this.datalistado.TabIndex = 0;
            this.datalistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalistado_CellContentClick);
            this.datalistado.DoubleClick += new System.EventHandler(this.datalistado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btncancelar);
            this.tabPage2.Controls.Add(this.btneditar);
            this.tabPage2.Controls.Add(this.btnguardar);
            this.tabPage2.Controls.Add(this.btnuevo);
            this.tabPage2.Controls.Add(this.txtdireccion);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtdocumento);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbotipodocumento);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dtfechanacimiento);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbosexo);
            this.tabPage2.Controls.Add(this.txtapellidos);
            this.tabPage2.Controls.Add(this.txtnombre);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtcodigo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(838, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(528, 257);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 19;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(447, 257);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 18;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(366, 257);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 17;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnuevo
            // 
            this.btnuevo.Location = new System.Drawing.Point(270, 257);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnuevo.TabIndex = 16;
            this.btnuevo.Text = "Nuevo";
            this.btnuevo.UseVisualStyleBackColor = true;
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(112, 191);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(491, 20);
            this.txtdireccion.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Direccion";
            // 
            // txtdocumento
            // 
            this.txtdocumento.Location = new System.Drawing.Point(382, 157);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(221, 20);
            this.txtdocumento.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Documento";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Items.AddRange(new object[] {
            "DNI",
            "RUC"});
            this.cbotipodocumento.Location = new System.Drawing.Point(112, 156);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(174, 21);
            this.cbotipodocumento.TabIndex = 11;
            this.cbotipodocumento.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo Document.";
            // 
            // dtfechanacimiento
            // 
            this.dtfechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechanacimiento.Location = new System.Drawing.Point(382, 124);
            this.dtfechanacimiento.Name = "dtfechanacimiento";
            this.dtfechanacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtfechanacimiento.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "fechanacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sexo";
            // 
            // cbosexo
            // 
            this.cbosexo.FormattingEnabled = true;
            this.cbosexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbosexo.Location = new System.Drawing.Point(114, 124);
            this.cbosexo.Name = "cbosexo";
            this.cbosexo.Size = new System.Drawing.Size(121, 21);
            this.cbosexo.TabIndex = 6;
            this.cbosexo.Text = "M";
            this.cbosexo.SelectedIndexChanged += new System.EventHandler(this.cbosexo_SelectedIndexChanged);
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(382, 81);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(221, 20);
            this.txtapellidos.TabIndex = 5;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(114, 81);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(198, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(114, 47);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // iconoerror
            // 
            this.iconoerror.ContainerControl = this;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmClientes";
            this.Text = "Mantenimiento de clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoerror)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ComboBox cbobuscar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbotipodocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtfechanacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbosexo;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip mensajetool;
        private System.Windows.Forms.ErrorProvider iconoerror;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
    }
}