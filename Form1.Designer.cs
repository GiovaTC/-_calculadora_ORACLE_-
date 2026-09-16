namespace CalculadoraOracle_19C
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // =====================================================
        // Controles de la calculadora
        // =====================================================

        private Label lblTitulo;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private TextBox txtResultado;

        private Label lblNumero1;
        private Label lblNumero2;
        private Label lblOperador;
        private Label lblResultado;

        private ComboBox cmbOperador;

        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnActualizar;
        private Button btnEliminarHistorial;

        // =====================================================
        // Historial
        // =====================================================

        private Label lblHistorial;
        private DataGridView dgvHistorial;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">
        /// true if managed resources should be disposed;
        /// otherwise, false.
        /// </param>
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
        /// Required method for Designer support.
        /// Do not modify the contents of this method with
        /// the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblTitulo = new Label();

            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            txtResultado = new TextBox();

            lblNumero1 = new Label();
            lblNumero2 = new Label();
            lblOperador = new Label();
            lblResultado = new Label();

            cmbOperador = new ComboBox();

            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnActualizar = new Button();
            btnEliminarHistorial = new Button();

            lblHistorial = new Label();
            dgvHistorial = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();

            SuspendLayout();

            // =====================================================
            // FORM1
            // =====================================================

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            BackColor = Color.White;

            ClientSize = new Size(1050, 650);

            FormBorderStyle = FormBorderStyle.FixedSingle;

            MaximizeBox = false;

            MinimizeBox = true;

            Name = "Form1";

            StartPosition = FormStartPosition.CenterScreen;

            Text = "Calculadora Oracle 19c";

            // =====================================================
            // TITULO
            // =====================================================

            lblTitulo.AutoSize = true;

            lblTitulo.Font = new Font(
                "Segoe UI",
                20F,
                FontStyle.Bold
            );

            lblTitulo.ForeColor = Color.FromArgb(
                40,
                40,
                40
            );

            lblTitulo.Location = new Point(55, 30);

            lblTitulo.Name = "lblTitulo";

            lblTitulo.Size = new Size(330, 37);

            lblTitulo.TabIndex = 0;

            lblTitulo.Text = "CALCULADORA ORACLE 19c";

            // =====================================================
            // LABEL NUMERO 1
            // =====================================================

            lblNumero1.AutoSize = true;

            lblNumero1.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );

            lblNumero1.Location = new Point(60, 105);

            lblNumero1.Name = "lblNumero1";

            lblNumero1.Size = new Size(75, 19);

            lblNumero1.TabIndex = 1;

            lblNumero1.Text = "Número 1:";

            // =====================================================
            // TXT NUMERO 1
            // =====================================================

            txtNumero1.Font = new Font(
                "Segoe UI",
                11F
            );

            txtNumero1.Location = new Point(155, 100);

            txtNumero1.Name = "txtNumero1";

            txtNumero1.Size = new Size(230, 27);

            txtNumero1.TabIndex = 2;

            // =====================================================
            // LABEL OPERADOR
            // =====================================================

            lblOperador.AutoSize = true;

            lblOperador.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );

            lblOperador.Location = new Point(60, 155);

            lblOperador.Name = "lblOperador";

            lblOperador.Size = new Size(72, 19);

            lblOperador.TabIndex = 3;

            lblOperador.Text = "Operador:";

            // =====================================================
            // COMBO OPERADOR
            // =====================================================

            cmbOperador.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbOperador.Font = new Font(
                "Segoe UI",
                11F
            );

            cmbOperador.FormattingEnabled = true;

            cmbOperador.Items.AddRange(
                new object[]
                {
                    "+",
                    "-",
                    "*",
                    "/"
                }
            );

            cmbOperador.Location = new Point(155, 150);

            cmbOperador.Name = "cmbOperador";

            cmbOperador.Size = new Size(230, 28);

            cmbOperador.TabIndex = 4;

            cmbOperador.SelectedIndex = 0;

            // =====================================================
            // LABEL NUMERO 2
            // =====================================================

            lblNumero2.AutoSize = true;

            lblNumero2.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );

            lblNumero2.Location = new Point(60, 205);

            lblNumero2.Name = "lblNumero2";

            lblNumero2.Size = new Size(75, 19);

            lblNumero2.TabIndex = 5;

            lblNumero2.Text = "Número 2:";

            // =====================================================
            // TXT NUMERO 2
            // =====================================================

            txtNumero2.Font = new Font(
                "Segoe UI",
                11F
            );

            txtNumero2.Location = new Point(155, 200);

            txtNumero2.Name = "txtNumero2";

            txtNumero2.Size = new Size(230, 27);

            txtNumero2.TabIndex = 6;

            // =====================================================
            // LABEL RESULTADO
            // =====================================================

            lblResultado.AutoSize = true;

            lblResultado.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );

            lblResultado.Location = new Point(60, 255);

            lblResultado.Name = "lblResultado";

            lblResultado.Size = new Size(77, 19);

            lblResultado.TabIndex = 7;

            lblResultado.Text = "Resultado:";

            // =====================================================
            // TXT RESULTADO
            // =====================================================

            txtResultado.BackColor =
                Color.FromArgb(
                    245,
                    245,
                    245
                );

            txtResultado.Font = new Font(
                "Segoe UI",
                13F,
                FontStyle.Bold
            );

            txtResultado.Location = new Point(
                155,
                248
            );

            txtResultado.Name = "txtResultado";

            txtResultado.ReadOnly = true;

            txtResultado.Size = new Size(
                230,
                31
            );

            txtResultado.TabIndex = 8;

            txtResultado.TextAlign =
                HorizontalAlignment.Right;

            // =====================================================
            // BOTON CALCULAR
            // =====================================================

            btnCalcular.BackColor =
                Color.FromArgb(
                    40,
                    167,
                    69
                );

            btnCalcular.FlatStyle =
                FlatStyle.Flat;

            btnCalcular.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );

            btnCalcular.ForeColor = Color.White;

            btnCalcular.Location = new Point(
                430,
                100
            );

            btnCalcular.Name = "btnCalcular";

            btnCalcular.Size = new Size(
                145,
                45
            );

            btnCalcular.TabIndex = 9;

            btnCalcular.Text = "CALCULAR";

            btnCalcular.UseVisualStyleBackColor = false;

            btnCalcular.Click += btnCalcular_Click;

            // =====================================================
            // BOTON LIMPIAR
            // =====================================================

            btnLimpiar.BackColor =
                Color.FromArgb(
                    108,
                    117,
                    125
                );

            btnLimpiar.FlatStyle =
                FlatStyle.Flat;

            btnLimpiar.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );

            btnLimpiar.ForeColor = Color.White;

            btnLimpiar.Location = new Point(
                595,
                100
            );

            btnLimpiar.Name = "btnLimpiar";

            btnLimpiar.Size = new Size(
                145,
                45
            );

            btnLimpiar.TabIndex = 10;

            btnLimpiar.Text = "LIMPIAR";

            btnLimpiar.UseVisualStyleBackColor = false;

            btnLimpiar.Click += btnLimpiar_Click;

            // =====================================================
            // BOTON ACTUALIZAR
            // =====================================================

            btnActualizar.BackColor =
                Color.FromArgb(
                    0,
                    123,
                    255
                );

            btnActualizar.FlatStyle =
                FlatStyle.Flat;

            btnActualizar.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );

            btnActualizar.ForeColor = Color.White;

            btnActualizar.Location = new Point(
                430,
                160
            );

            btnActualizar.Name = "btnActualizar";

            btnActualizar.Size = new Size(
                145,
                45
            );

            btnActualizar.TabIndex = 11;

            btnActualizar.Text = "ACTUALIZAR";

            btnActualizar.UseVisualStyleBackColor = false;

            btnActualizar.Click += btnActualizar_Click;

            // =====================================================
            // BOTON ELIMINAR HISTORIAL
            // =====================================================

            btnEliminarHistorial.BackColor =
                Color.FromArgb(
                    220,
                    53,
                    69
                );

            btnEliminarHistorial.FlatStyle =
                FlatStyle.Flat;

            btnEliminarHistorial.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );

            btnEliminarHistorial.ForeColor = Color.White;

            btnEliminarHistorial.Location = new Point(
                595,
                160
            );

            btnEliminarHistorial.Name =
                "btnEliminarHistorial";

            btnEliminarHistorial.Size = new Size(
                145,
                45
            );

            btnEliminarHistorial.TabIndex = 12;

            btnEliminarHistorial.Text =
                "ELIMINAR HISTORIAL";

            btnEliminarHistorial.UseVisualStyleBackColor =
                false;

            btnEliminarHistorial.Click +=
                btnEliminarHistorial_Click;

            // =====================================================
            // LABEL HISTORIAL
            // =====================================================

            lblHistorial.AutoSize = true;

            lblHistorial.Font = new Font(
                "Segoe UI",
                13F,
                FontStyle.Bold
            );

            lblHistorial.Location = new Point(
                55,
                320
            );

            lblHistorial.Name = "lblHistorial";

            lblHistorial.Size = new Size(
                105,
                25
            );

            lblHistorial.TabIndex = 13;

            lblHistorial.Text = "HISTORIAL";

            // =====================================================
            // DATAGRIDVIEW
            // =====================================================

            dgvHistorial.AllowUserToAddRows = false;

            dgvHistorial.AllowUserToDeleteRows = false;

            dgvHistorial.AllowUserToResizeRows = false;

            dgvHistorial.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvHistorial.BackgroundColor =
                Color.White;

            dgvHistorial.BorderStyle =
                BorderStyle.FixedSingle;

            dgvHistorial.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvHistorial.Location = new Point(
                55,
                355
            );

            dgvHistorial.MultiSelect = false;

            dgvHistorial.Name = "dgvHistorial";

            dgvHistorial.ReadOnly = true;

            dgvHistorial.RowHeadersVisible = false;

            dgvHistorial.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvHistorial.Size = new Size(
                930,
                230
            );

            dgvHistorial.TabIndex = 14;

            // =====================================================
            // AGREGAR CONTROLES AL FORMULARIO
            // =====================================================

            Controls.Add(lblTitulo);

            Controls.Add(lblNumero1);
            Controls.Add(txtNumero1);

            Controls.Add(lblOperador);
            Controls.Add(cmbOperador);

            Controls.Add(lblNumero2);
            Controls.Add(txtNumero2);

            Controls.Add(lblResultado);
            Controls.Add(txtResultado);

            Controls.Add(btnCalcular);
            Controls.Add(btnLimpiar);

            Controls.Add(btnActualizar);
            Controls.Add(btnEliminarHistorial);

            Controls.Add(lblHistorial);
            Controls.Add(dgvHistorial);

            // =====================================================
            // FINALIZAR FORMULARIO
            // =====================================================

            ((System.ComponentModel.ISupportInitialize)dgvHistorial)
                .EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}