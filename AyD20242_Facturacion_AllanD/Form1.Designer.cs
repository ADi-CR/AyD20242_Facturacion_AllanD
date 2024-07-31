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
            TxtConsultarCorreo = new TextBox();
            BtnConsultarCorreo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Green;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.Location = new Point(12, 677);
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
            dataGridView1.Size = new Size(895, 252);
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
            // TxtConsultarCorreo
            // 
            TxtConsultarCorreo.Location = new Point(23, 24);
            TxtConsultarCorreo.Multiline = true;
            TxtConsultarCorreo.Name = "TxtConsultarCorreo";
            TxtConsultarCorreo.ScrollBars = ScrollBars.Both;
            TxtConsultarCorreo.Size = new Size(412, 48);
            TxtConsultarCorreo.TabIndex = 0;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 734);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(BtnAgregar);
            Name = "Form1";
            Text = "--";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAgregar;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox TxtConsultarCorreo;
        private Button BtnConsultarCorreo;
    }
}
