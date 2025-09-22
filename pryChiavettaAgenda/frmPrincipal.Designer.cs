namespace pryChiavettaAgenda
{
    partial class frmPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            lblContacto = new Label();
            lblTitulo = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblTelefono = new Label();
            lstDatos = new ListBox();
            mtbNumero = new MaskedTextBox();
            txtContacto = new TextBox();
            lblCant = new Label();
            lblFecha = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblContador = new Label();
            label2 = new Label();
            btnVercontactos = new Button();
            btnVer = new Button();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(57, 84);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(105, 22);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "-Contacto-";
            lblContacto.Click += lblContacto_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(143, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(194, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Agenda de contactos";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.ControlText;
            btnAceptar.Enabled = false;
            btnAceptar.ForeColor = Color.AliceBlue;
            btnAceptar.Location = new Point(332, 396);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(121, 42);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlText;
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(174, 396);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 42);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(318, 84);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(100, 22);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "-Telefono-";
            lblTelefono.Click += lblTelefono_Click;
            // 
            // lstDatos
            // 
            lstDatos.FormattingEnabled = true;
            lstDatos.ItemHeight = 15;
            lstDatos.Location = new Point(20, 174);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(419, 124);
            lstDatos.TabIndex = 6;
            lstDatos.SelectedIndexChanged += lsbDatos_SelectedIndexChanged;
            // 
            // mtbNumero
            // 
            mtbNumero.Location = new Point(301, 124);
            mtbNumero.Mask = "(999)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(130, 23);
            mtbNumero.TabIndex = 7;
            mtbNumero.MaskInputRejected += mskNumero_MaskInputRejected;
            mtbNumero.TextChanged += mtbNumero_TextChanged;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(35, 124);
            txtContacto.Multiline = true;
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(153, 23);
            txtContacto.TabIndex = 8;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // lblCant
            // 
            lblCant.AutoSize = true;
            lblCant.BackColor = SystemColors.Desktop;
            lblCant.Font = new Font("Segoe UI", 12F);
            lblCant.ForeColor = Color.Cornsilk;
            lblCant.Location = new Point(3, 337);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(165, 21);
            lblCant.TabIndex = 9;
            lblCant.Text = " Contactos Agendados";
            lblCant.Click += lblCant_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = SystemColors.Desktop;
            lblFecha.Font = new Font("Segoe UI", 12F);
            lblFecha.ForeColor = Color.Cornsilk;
            lblFecha.Location = new Point(12, 396);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 21);
            lblFecha.TabIndex = 10;
            lblFecha.Click += label1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Text = "Agenda setting";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.BackColor = SystemColors.ControlLight;
            lblContador.Font = new Font("Microsoft Sans Serif", 12F);
            lblContador.Location = new Point(174, 338);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(18, 20);
            lblContador.TabIndex = 11;
            lblContador.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(99, 401);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 12;
            // 
            // btnVercontactos
            // 
            btnVercontactos.BackColor = SystemColors.ControlText;
            btnVercontactos.ForeColor = SystemColors.ControlLightLight;
            btnVercontactos.Location = new Point(12, 396);
            btnVercontactos.Name = "btnVercontactos";
            btnVercontactos.Size = new Size(121, 42);
            btnVercontactos.TabIndex = 13;
            btnVercontactos.Text = "Ver contactos";
            btnVercontactos.UseVisualStyleBackColor = false;
            btnVercontactos.Click += btnVercontactos_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(198, 337);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(75, 23);
            btnVer.TabIndex = 14;
            btnVer.Text = "ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(465, 450);
            Controls.Add(btnVer);
            Controls.Add(btnVercontactos);
            Controls.Add(label2);
            Controls.Add(lblContador);
            Controls.Add(lblFecha);
            Controls.Add(lblCant);
            Controls.Add(txtContacto);
            Controls.Add(mtbNumero);
            Controls.Add(lstDatos);
            Controls.Add(lblTelefono);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblTitulo);
            Controls.Add(lblContacto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContacto;
        private Label lblTitulo;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblTelefono;
        private ListBox lstDatos;
        private MaskedTextBox mtbNumero;
        private TextBox txtContacto;
        private Label lblCant;
        private Label lblFecha;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblContador;
        private Label label2;
        private Button btnVercontactos;
        private Button btnVer;
    }
}
