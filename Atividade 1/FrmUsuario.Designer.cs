namespace Atividade_1
{
    partial class FrmUsuario
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
            BtnSair = new ReaLTaiizor.Controls.AirButton();
            SuspendLayout();
            // 
            // BtnSair
            // 
            BtnSair.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            BtnSair.Font = new Font("Segoe UI", 9F);
            BtnSair.Image = null;
            BtnSair.Location = new Point(77, 101);
            BtnSair.Name = "BtnSair";
            BtnSair.NoRounding = false;
            BtnSair.Size = new Size(150, 68);
            BtnSair.TabIndex = 0;
            BtnSair.Text = "Sair";
            BtnSair.Transparent = false;
            BtnSair.Click += airButton1_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSair);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.AirButton BtnSair;
    }
}