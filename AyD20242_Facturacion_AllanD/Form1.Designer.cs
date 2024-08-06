namespace AyD20242_Facturacion_AllanD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnAgregar = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            BtnConsultarCorreo = new Button();
            TxtConsultarCorreo = new TextBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            CboxUsuarioRol = new ComboBox();
            label7 = new Label();
            TxtNotas = new TextBox();
            label6 = new Label();
            TxtIdentificacion = new TextBox();
            label5 = new Label();
            TxtCorreo = new TextBox();
            label4 = new Label();
            TxtContrasennia = new TextBox();
            label3 = new Label();
            TxtTelefono = new TextBox();
            label2 = new Label();
            TxtDireccion = new TextBox();
            label1 = new Label();
            TxtNombreCompleto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Green;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.Location = new Point(12, 658);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(249, 45);
            BtnAgregar.TabIndex = 0;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(895, 239);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnConsultarCorreo);
            groupBox1.Controls.Add(TxtConsultarCorreo);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(895, 104);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consultar Usuario por Correo";
            // 
            // BtnConsultarCorreo
            // 
            BtnConsultarCorreo.Location = new Point(471, 31);
            BtnConsultarCorreo.Name = "BtnConsultarCorreo";
            BtnConsultarCorreo.Size = new Size(216, 33);
            BtnConsultarCorreo.TabIndex = 1;
            BtnConsultarCorreo.Text = "Consultar";
            BtnConsultarCorreo.UseVisualStyleBackColor = true;
            BtnConsultarCorreo.Click += BtnConsultarCorreo_Click;
            // 
            // TxtConsultarCorreo
            // 
            TxtConsultarCorreo.Location = new Point(23, 24);
            TxtConsultarCorreo.Multiline = true;
            TxtConsultarCorreo.Name = "TxtConsultarCorreo";
            TxtConsultarCorreo.ScrollBars = ScrollBars.Both;
            TxtConsultarCorreo.Size = new Size(412, 48);
            TxtConsultarCorreo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(CboxUsuarioRol);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(TxtNotas);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(TxtIdentificacion);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(TxtCorreo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(TxtContrasennia);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(TxtTelefono);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(TxtDireccion);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(TxtNombreCompleto);
            groupBox2.Location = new Point(12, 377);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(895, 258);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Usuario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(486, 72);
            label8.Name = "label8";
            label8.Size = new Size(95, 17);
            label8.TabIndex = 15;
            label8.Text = "Rol de Usuario";
            // 
            // CboxUsuarioRol
            // 
            CboxUsuarioRol.FormattingEnabled = true;
            CboxUsuarioRol.Location = new Point(610, 69);
            CboxUsuarioRol.Name = "CboxUsuarioRol";
            CboxUsuarioRol.Size = new Size(255, 25);
            CboxUsuarioRol.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 204);
            label7.Name = "label7";
            label7.Size = new Size(46, 17);
            label7.TabIndex = 13;
            label7.Text = "Notas:";
            // 
            // TxtNotas
            // 
            TxtNotas.Location = new Point(130, 201);
            TxtNotas.Multiline = true;
            TxtNotas.Name = "TxtNotas";
            TxtNotas.ScrollBars = ScrollBars.Both;
            TxtNotas.Size = new Size(735, 40);
            TxtNotas.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 77);
            label6.Name = "label6";
            label6.Size = new Size(87, 17);
            label6.TabIndex = 11;
            label6.Text = "Identificación:";
            // 
            // TxtIdentificacion
            // 
            TxtIdentificacion.Location = new Point(130, 73);
            TxtIdentificacion.Name = "TxtIdentificacion";
            TxtIdentificacion.Size = new Size(255, 25);
            TxtIdentificacion.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 113);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 9;
            label5.Text = "Correo:";
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(130, 110);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(255, 25);
            TxtCorreo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(486, 27);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 7;
            label4.Text = "Contraseña:";
            // 
            // TxtContrasennia
            // 
            TxtContrasennia.Location = new Point(610, 24);
            TxtContrasennia.Name = "TxtContrasennia";
            TxtContrasennia.Size = new Size(255, 25);
            TxtContrasennia.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(486, 108);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 5;
            label3.Text = "Telefóno:";
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new Point(610, 105);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(255, 25);
            TxtTelefono.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 153);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 3;
            label2.Text = "Dirección:";
            // 
            // TxtDireccion
            // 
            TxtDireccion.Location = new Point(130, 150);
            TxtDireccion.Multiline = true;
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.ScrollBars = ScrollBars.Both;
            TxtDireccion.Size = new Size(735, 40);
            TxtDireccion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(118, 17);
            label1.TabIndex = 1;
            label1.Text = "Nombre Completo";
            // 
            // TxtNombreCompleto
            // 
            TxtNombreCompleto.Location = new Point(130, 39);
            TxtNombreCompleto.Name = "TxtNombreCompleto";
            TxtNombreCompleto.Size = new Size(255, 25);
            TxtNombreCompleto.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 734);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(BtnAgregar);
            Name = "Form1";
            Text = "--";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAgregar;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox TxtConsultarCorreo;
        private Button BtnConsultarCorreo;
        private GroupBox groupBox2;
        private TextBox TxtNombreCompleto;
        private Label label7;
        private TextBox TxtNotas;
        private Label label6;
        private TextBox TxtIdentificacion;
        private Label label5;
        private TextBox TxtCorreo;
        private Label label4;
        private TextBox TxtContrasennia;
        private Label label3;
        private TextBox TxtTelefono;
        private Label label2;
        private TextBox TxtDireccion;
        private Label label1;
        private Label label8;
        private ComboBox CboxUsuarioRol;
    }
}
