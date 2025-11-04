namespace pryDelgadoAgendaContacto
{
    partial class frmAgendarNumero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendarNumero));
            cmdRegistrar = new Button();
            lblContacto = new Label();
            lblNumero = new Label();
            lblTitulo = new Label();
            txtContacto = new TextBox();
            mskNumero = new MaskedTextBox();
            cmdCancelar = new Button();
            lstbLista = new ListBox();
            lblCantidadCon = new Label();
            lblFechaHora = new Label();
            SuspendLayout();
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Enabled = false;
            cmdRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmdRegistrar.Location = new Point(12, 248);
            cmdRegistrar.Margin = new Padding(3, 4, 3, 4);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(109, 36);
            cmdRegistrar.TabIndex = 0;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(12, 98);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(88, 25);
            lblContacto.TabIndex = 1;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(12, 177);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(81, 25);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Número";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(110, 32);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "AGENDA";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(152, 100);
            txtContacto.Margin = new Padding(3, 4, 3, 4);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(188, 27);
            txtContacto.TabIndex = 4;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // mskNumero
            // 
            mskNumero.Enabled = false;
            mskNumero.Location = new Point(152, 173);
            mskNumero.Margin = new Padding(3, 4, 3, 4);
            mskNumero.Mask = "(351)000-0000";
            mskNumero.Name = "mskNumero";
            mskNumero.Size = new Size(188, 27);
            mskNumero.TabIndex = 6;
            mskNumero.MaskInputRejected += mskNumero_MaskInputRejected;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmdCancelar.Location = new Point(166, 248);
            cmdCancelar.Margin = new Padding(3, 4, 3, 4);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(109, 36);
            cmdCancelar.TabIndex = 7;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // lstbLista
            // 
            lstbLista.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstbLista.FormattingEnabled = true;
            lstbLista.ItemHeight = 21;
            lstbLista.Location = new Point(21, 335);
            lstbLista.Margin = new Padding(3, 4, 3, 4);
            lstbLista.Name = "lstbLista";
            lstbLista.Size = new Size(354, 109);
            lstbLista.TabIndex = 8;
            // 
            // lblCantidadCon
            // 
            lblCantidadCon.AutoSize = true;
            lblCantidadCon.Location = new Point(246, 458);
            lblCantidadCon.Name = "lblCantidadCon";
            lblCantidadCon.Size = new Size(0, 20);
            lblCantidadCon.TabIndex = 12;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(21, 486);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 20);
            lblFechaHora.TabIndex = 13;
            // 
            // frmAgendarNumero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 539);
            Controls.Add(lblFechaHora);
            Controls.Add(lblCantidadCon);
            Controls.Add(lstbLista);
            Controls.Add(cmdCancelar);
            Controls.Add(mskNumero);
            Controls.Add(txtContacto);
            Controls.Add(lblTitulo);
            Controls.Add(lblNumero);
            Controls.Add(lblContacto);
            Controls.Add(cmdRegistrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAgendarNumero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += frmAgendarNumero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdRegistrar;
        private Label lblContacto;
        private Label lblNumero;
        private Label lblTitulo;
        private TextBox txtContacto;
        private MaskedTextBox mskNumero;
        private Button cmdCancelar;
        private ListBox lstbLista;
        private Label lblCantidadCon;
        private Label lblFechaHora;
    }
}
