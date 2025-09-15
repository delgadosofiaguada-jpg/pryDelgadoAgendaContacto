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
            cmdRegistrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdRegistrar.Location = new Point(44, 267);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(116, 34);
            cmdRegistrar.TabIndex = 0;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(44, 112);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(69, 20);
            lblContacto.TabIndex = 1;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(44, 171);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 20);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Número";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(241, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(90, 25);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "AGENDA";
            lblTitulo.Click += label3_Click;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(166, 113);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(165, 23);
            txtContacto.TabIndex = 4;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // mskNumero
            // 
            mskNumero.Enabled = false;
            mskNumero.Location = new Point(166, 168);
            mskNumero.Mask = "(351)000-0000";
            mskNumero.Name = "mskNumero";
            mskNumero.Size = new Size(165, 23);
            mskNumero.TabIndex = 6;
            mskNumero.MaskInputRejected += mskNumero_MaskInputRejected;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdCancelar.Location = new Point(215, 267);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(116, 34);
            cmdCancelar.TabIndex = 7;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // lstbLista
            // 
            lstbLista.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstbLista.FormattingEnabled = true;
            lstbLista.ItemHeight = 17;
            lstbLista.Location = new Point(44, 348);
            lstbLista.Name = "lstbLista";
            lstbLista.Size = new Size(291, 89);
            lstbLista.TabIndex = 8;
            // 
            // lblCantidadCon
            // 
            lblCantidadCon.AutoSize = true;
            lblCantidadCon.Location = new Point(48, 508);
            lblCantidadCon.Name = "lblCantidadCon";
            lblCantidadCon.Size = new Size(0, 15);
            lblCantidadCon.TabIndex = 12;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(321, 514);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 15);
            lblFechaHora.TabIndex = 13;
            // 
            // frmAgendarNumero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 579);
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
            Name = "frmAgendarNumero";
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
