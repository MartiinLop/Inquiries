
namespace TemplateParteAdmin
{
    partial class MiniUsuExpandir
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTipoGrup = new System.Windows.Forms.Label();
            this.lblNA = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.lblTipoGrup);
            this.panel1.Controls.Add(this.lblNA);
            this.panel1.Location = new System.Drawing.Point(-2, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 49);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.Clickeado);
            // 
            // lblTipoGrup
            // 
            this.lblTipoGrup.AutoSize = true;
            this.lblTipoGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoGrup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.lblTipoGrup.Location = new System.Drawing.Point(3, 26);
            this.lblTipoGrup.Name = "lblTipoGrup";
            this.lblTipoGrup.Size = new System.Drawing.Size(173, 18);
            this.lblTipoGrup.TabIndex = 4;
            this.lblTipoGrup.Text = "Docente/Alumno - Grupo";
            this.lblTipoGrup.Click += new System.EventHandler(this.Clickeado);
            // 
            // lblNA
            // 
            this.lblNA.AutoSize = true;
            this.lblNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.lblNA.Location = new System.Drawing.Point(1, 0);
            this.lblNA.Name = "lblNA";
            this.lblNA.Size = new System.Drawing.Size(167, 24);
            this.lblNA.TabIndex = 3;
            this.lblNA.Text = "Nombre y Apellido";
            this.lblNA.Click += new System.EventHandler(this.Clickeado);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Clickeado);
            // 
            // MiniUsuExpandir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(209, 111);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MiniUsuExpandir";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MiniUsuExpandir_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTipoGrup;
        private System.Windows.Forms.Label lblNA;
    }
}