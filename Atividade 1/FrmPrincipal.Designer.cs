namespace Atividade_1
{
    partial class FrmPrincipal
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
            BtnUsuario = new ReaLTaiizor.Controls.AirButton();
            BtnChamado = new ReaLTaiizor.Controls.AirButton();
            BtnSair = new ReaLTaiizor.Controls.AirButton();
            SuspendLayout();
            // 
            // BtnUsuario
            // 
            BtnUsuario.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            BtnUsuario.Font = new Font("Segoe UI", 9F);
            BtnUsuario.Image = null;
            BtnUsuario.Location = new Point(82, 101);
            BtnUsuario.Name = "BtnUsuario";
            BtnUsuario.NoRounding = false;
            BtnUsuario.Size = new Size(230, 217);
            BtnUsuario.TabIndex = 0;
            BtnUsuario.Text = "Usuario";
            BtnUsuario.Transparent = false;
            BtnUsuario.Click += BtnUsuario_Click;
            // 
            // BtnChamado
            // 
            BtnChamado.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            BtnChamado.Font = new Font("Segoe UI", 9F);
            BtnChamado.Image = null;
            BtnChamado.Location = new Point(357, 101);
            BtnChamado.Name = "BtnChamado";
            BtnChamado.NoRounding = false;
            BtnChamado.Size = new Size(230, 217);
            BtnChamado.TabIndex = 1;
            BtnChamado.Text = "Chamado";
            BtnChamado.Transparent = false;
            BtnChamado.Click += BtnChamado_Click;
            // 
            // BtnSair
            // 
            BtnSair.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            BtnSair.Font = new Font("Segoe UI", 9F);
            BtnSair.Image = null;
            BtnSair.Location = new Point(83, 360);
            BtnSair.Name = "BtnSair";
            BtnSair.NoRounding = false;
            BtnSair.Size = new Size(150, 68);
            BtnSair.TabIndex = 2;
            BtnSair.Text = "Sair";
            BtnSair.Transparent = false;
            BtnSair.Click += BtnSair_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSair);
            Controls.Add(BtnChamado);
            Controls.Add(BtnUsuario);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.AirButton BtnUsuario;
        private ReaLTaiizor.Controls.AirButton BtnChamado;
        private ReaLTaiizor.Controls.AirButton BtnSair;
    }
}