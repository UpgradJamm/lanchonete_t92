
namespace Lanchonete_T92
{
    partial class PrincipalView
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
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.sairBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imagemLateral = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLateral)).BeginInit();
            this.SuspendLayout();
            // 
            // logoImg
            // 
            this.logoImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoImg.BackColor = System.Drawing.Color.Transparent;
            this.logoImg.BackgroundImage = global::Lanchonete_T92.Properties.Resources.logo_copiar2;
            this.logoImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoImg.Location = new System.Drawing.Point(83, 89);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(234, 148);
            this.logoImg.TabIndex = 1;
            this.logoImg.TabStop = false;
            // 
            // sairBtn
            // 
            this.sairBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sairBtn.BackColor = System.Drawing.Color.Transparent;
            this.sairBtn.BackgroundImage = global::Lanchonete_T92.Properties.Resources.botao_ligar_desligar;
            this.sairBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sairBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sairBtn.FlatAppearance.BorderSize = 0;
            this.sairBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sairBtn.ForeColor = System.Drawing.Color.Transparent;
            this.sairBtn.Location = new System.Drawing.Point(761, 3);
            this.sairBtn.Name = "sairBtn";
            this.sairBtn.Size = new System.Drawing.Size(39, 16);
            this.sairBtn.TabIndex = 4;
            this.sairBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.logoImg);
            this.panel1.Location = new System.Drawing.Point(236, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 338);
            this.panel1.TabIndex = 5;
            // 
            // imagemLateral
            // 
            this.imagemLateral.BackColor = System.Drawing.Color.Black;
            this.imagemLateral.BackgroundImage = global::Lanchonete_T92.Properties.Resources.login;
            this.imagemLateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagemLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagemLateral.Location = new System.Drawing.Point(0, 0);
            this.imagemLateral.Name = "imagemLateral";
            this.imagemLateral.Size = new System.Drawing.Size(219, 450);
            this.imagemLateral.TabIndex = 0;
            this.imagemLateral.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImage = global::Lanchonete_T92.Properties.Resources.menu_b;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(6, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 24);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // PrincipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(229)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sairBtn);
            this.Controls.Add(this.imagemLateral);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalView";
            this.Load += new System.EventHandler(this.PrincipalView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagemLateral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.Button sairBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imagemLateral;
        private System.Windows.Forms.Button button2;
    }
}