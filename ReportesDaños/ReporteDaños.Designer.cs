namespace LaboratorioDeAutomatizacion_Almacen.ReportesDaños
{
    partial class ReporteDaños
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
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNombreMaterial = new Label();
            txtMaterial = new MaskedTextBox();
            lblReporte = new Label();
            txtReporte = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            chkEstudiante = new CheckBox();
            lblFolio = new Label();
            txtFolioVale = new TextBox();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(24, 28);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(141, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo de Material:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(171, 25);
            txtCodigo.MaxLength = 4;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 1;
            // 
            // lblNombreMaterial
            // 
            lblNombreMaterial.AutoSize = true;
            lblNombreMaterial.Location = new Point(24, 88);
            lblNombreMaterial.Name = "lblNombreMaterial";
            lblNombreMaterial.Size = new Size(147, 20);
            lblNombreMaterial.TabIndex = 2;
            lblNombreMaterial.Text = "Nombre de Material:";
            // 
            // txtMaterial
            // 
            txtMaterial.BackColor = SystemColors.ActiveBorder;
            txtMaterial.Location = new Point(177, 85);
            txtMaterial.Name = "txtMaterial";
            txtMaterial.ReadOnly = true;
            txtMaterial.Size = new Size(125, 27);
            txtMaterial.TabIndex = 3;
            txtMaterial.TabStop = false;
            txtMaterial.MaskInputRejected += txtMaterial_MaskInputRejected;
            // 
            // lblReporte
            // 
            lblReporte.AutoSize = true;
            lblReporte.Location = new Point(320, 28);
            lblReporte.Name = "lblReporte";
            lblReporte.Size = new Size(128, 20);
            lblReporte.TabIndex = 4;
            lblReporte.Text = "Reporte del daño:";
            lblReporte.Click += lblReporte_Click;
            // 
            // txtReporte
            // 
            txtReporte.Location = new Point(454, 28);
            txtReporte.Multiline = true;
            txtReporte.Name = "txtReporte";
            txtReporte.Size = new Size(300, 100);
            txtReporte.TabIndex = 5;
            txtReporte.TextChanged += textBox2_TextChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(24, 144);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(130, 20);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha de Registro:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(160, 144);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 7;
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(24, 203);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(192, 24);
            chkEstudiante.TabIndex = 8;
            chkEstudiante.Text = "¿Lo daño un estudiante?";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // lblFolio
            // 
            lblFolio.AutoSize = true;
            lblFolio.Location = new Point(24, 257);
            lblFolio.Name = "lblFolio";
            lblFolio.Size = new Size(97, 20);
            lblFolio.TabIndex = 9;
            lblFolio.Text = "Folio de vale:";
            // 
            // txtFolioVale
            // 
            txtFolioVale.Enabled = false;
            txtFolioVale.Location = new Point(127, 257);
            txtFolioVale.Name = "txtFolioVale";
            txtFolioVale.Size = new Size(125, 27);
            txtFolioVale.TabIndex = 10;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(275, 260);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "Estado:";
            lblEstado.Click += label6_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(338, 257);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(151, 28);
            cmbEstado.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(576, 512);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(676, 512);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(476, 512);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 327);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 16;
            // 
            // ReporteDaños
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(dataGridView1);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtFolioVale);
            Controls.Add(lblFolio);
            Controls.Add(chkEstudiante);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(txtReporte);
            Controls.Add(lblReporte);
            Controls.Add(txtMaterial);
            Controls.Add(lblNombreMaterial);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReporteDaños";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Daños";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblNombreMaterial;
        private MaskedTextBox txtMaterial;
        private Label lblReporte;
        private TextBox txtReporte;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private CheckBox chkEstudiante;
        private Label lblFolio;
        private TextBox txtFolioVale;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Button btnGuardar;
        private DataGridView dataGridView1;
    }
}