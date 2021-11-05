
namespace TemplateParteAdmin
{
    partial class FORPanelMiniGrupAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORPanelMiniGrupAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblAsignatura);
            this.panel1.Controls.Add(this.lblGrupo);
            this.panel1.Location = new System.Drawing.Point(-2, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 49);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.Clickeado);
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.lblAsignatura.Location = new System.Drawing.Point(54, 21);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(77, 18);
            this.lblAsignatura.TabIndex = 4;
            this.lblAsignatura.Text = "Asignatura";
            this.lblAsignatura.Click += new System.EventHandler(this.Clickeado);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.lblGrupo.Location = new System.Drawing.Point(53, 0);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(63, 24);
            this.lblGrupo.TabIndex = 3;
            this.lblGrupo.Text = "Grupo";
            this.lblGrupo.Click += new System.EventHandler(this.Clickeado);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // MiniUsuExpandir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(209, 111);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MiniUsuExpandir";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}