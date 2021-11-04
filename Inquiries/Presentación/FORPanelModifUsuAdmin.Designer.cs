
namespace TemplateParteAdmin
{
    partial class FORPanelModifUsuAdmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNA = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelG = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.btnModif = new System.Windows.Forms.Button();
            this.lblCedula = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNA
            // 
            this.labelNA.AutoSize = true;
            this.labelNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNA.Location = new System.Drawing.Point(82, 6);
            this.labelNA.Name = "labelNA";
            this.labelNA.Size = new System.Drawing.Size(325, 39);
            this.labelNA.TabIndex = 0;
            this.labelNA.Text = "Nombre y Apellido - ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelG.Location = new System.Drawing.Point(332, 5);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(131, 39);
            this.labelG.TabIndex = 2;
            this.labelG.Text = "Grupo -";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(444, 6);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(269, 39);
            this.labelTipo.TabIndex = 3;
            this.labelTipo.Text = "Alumno/Docente";
            // 
            // btnModif
            // 
            this.btnModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModif.Location = new System.Drawing.Point(738, 6);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(142, 32);
            this.btnModif.TabIndex = 4;
            this.btnModif.Text = "Modificar";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(180, 6);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(50, 17);
            this.lblCedula.TabIndex = 5;
            this.lblCedula.Text = "cedula";
            this.lblCedula.Visible = false;
            // 
            // FORPanelModifUsuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(892, 44);
            this.ControlBox = false;
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "FORPanelModifUsuAdmin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FORPanelDatosUsuAdmin";
            this.Load += new System.EventHandler(this.FORPanelElimUsuAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Label lblCedula;
    }
}

