namespace Atividade_1
{
    partial class FrmChamado
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
            btnSair = new ReaLTaiizor.Controls.AirButton();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnSair.Font = new Font("Segoe UI", 9F);
            btnSair.Image = null;
            btnSair.Location = new Point(68, 108);
            btnSair.Name = "btnSair";
            btnSair.NoRounding = false;
            btnSair.Size = new Size(150, 68);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair";
            btnSair.Transparent = false;
            btnSair.Click += btnSair_Click;
            // 
            // FrmChamado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Name = "FrmChamado";
            Text = "FrmChamado";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.AirButton btnSair;
    }
}