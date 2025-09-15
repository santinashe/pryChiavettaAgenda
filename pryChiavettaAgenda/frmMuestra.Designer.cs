namespace pryChiavettaAgenda
{
    partial class frmMuestra
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
            lblContactoss = new Label();
            btnAtras = new Button();
            btnSigiente = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblContactoss
            // 
            lblContactoss.AutoSize = true;
            lblContactoss.BackColor = SystemColors.ControlText;
            lblContactoss.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactoss.ForeColor = SystemColors.ControlLight;
            lblContactoss.Location = new Point(332, 140);
            lblContactoss.Name = "lblContactoss";
            lblContactoss.Size = new Size(133, 30);
            lblContactoss.TabIndex = 0;
            lblContactoss.Text = "CONTACTOS";
            lblContactoss.Click += lblContactoss_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ControlText;
            btnAtras.Cursor = Cursors.AppStarting;
            btnAtras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtras.ForeColor = SystemColors.ButtonFace;
            btnAtras.Location = new Point(114, 325);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(175, 71);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "ATRAS";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnSigiente
            // 
            btnSigiente.BackColor = Color.Black;
            btnSigiente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSigiente.ForeColor = SystemColors.ControlLightLight;
            btnSigiente.Location = new Point(510, 325);
            btnSigiente.Name = "btnSigiente";
            btnSigiente.Size = new Size(175, 71);
            btnSigiente.TabIndex = 2;
            btnSigiente.Text = "SIGUIENTE";
            btnSigiente.UseVisualStyleBackColor = false;
            btnSigiente.Click += btnSigiente_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(717, 425);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmMuestra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnSigiente);
            Controls.Add(btnAtras);
            Controls.Add(lblContactoss);
            Name = "frmMuestra";
            Text = "Contactos";
            Load += frmMuestra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContactoss;
        private Button btnAtras;
        private Button btnSigiente;
        private Button btnVolver;
    }
}