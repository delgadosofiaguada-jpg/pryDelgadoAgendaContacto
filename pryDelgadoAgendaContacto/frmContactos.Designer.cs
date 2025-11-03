namespace pryDelgadoAgendaContacto
{
    partial class frmContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContactos));
            cmdAnterior = new Button();
            lblTitulo = new Label();
            cmdSiguiente = new Button();
            lblDato = new Label();
            grbContacto = new GroupBox();
            grbContacto.SuspendLayout();
            SuspendLayout();
            // 
            // cmdAnterior
            // 
            cmdAnterior.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdAnterior.Location = new Point(105, 255);
            cmdAnterior.Name = "cmdAnterior";
            cmdAnterior.Size = new Size(83, 31);
            cmdAnterior.TabIndex = 0;
            cmdAnterior.Text = "Anterior";
            cmdAnterior.UseVisualStyleBackColor = true;
            cmdAnterior.Click += cmdAnterior_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(41, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(123, 20);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Buscar Contacto";
            lblTitulo.Click += label1_Click;
            // 
            // cmdSiguiente
            // 
            cmdSiguiente.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdSiguiente.Location = new Point(194, 255);
            cmdSiguiente.Name = "cmdSiguiente";
            cmdSiguiente.Size = new Size(98, 31);
            cmdSiguiente.TabIndex = 5;
            cmdSiguiente.Text = "Siguiente";
            cmdSiguiente.UseVisualStyleBackColor = true;
            cmdSiguiente.Click += cmdSiguiente_Click;
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDato.Location = new Point(15, 34);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(0, 25);
            lblDato.TabIndex = 6;
            // 
            // grbContacto
            // 
            grbContacto.Controls.Add(lblDato);
            grbContacto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbContacto.Location = new Point(41, 86);
            grbContacto.Name = "grbContacto";
            grbContacto.Size = new Size(200, 100);
            grbContacto.TabIndex = 7;
            grbContacto.TabStop = false;
            grbContacto.Text = "Contacto";
            // 
            // frmContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 347);
            Controls.Add(cmdSiguiente);
            Controls.Add(lblTitulo);
            Controls.Add(cmdAnterior);
            Controls.Add(grbContacto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmContactos";
            Text = "frmContactos";
            Load += frmContactos_Load;
            grbContacto.ResumeLayout(false);
            grbContacto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdAnterior;
        private Label lblTitulo;
        private Button cmdSiguiente;
        private Label lblDato;
        private GroupBox grbContacto;
    }
}