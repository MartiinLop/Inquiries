
namespace TemplateParteAdmin
{
    partial class FORPanelChatsConsultasPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORPanelChatsConsultasPrincipal));
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblOrientacion = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocente.Location = new System.Drawing.Point(54, 9);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(92, 24);
            this.lblDocente.TabIndex = 1;
            this.lblDocente.Text = "Docente -";
            this.lblDocente.Click += new System.EventHandler(this.metodo_Click);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(194, 9);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(87, 24);
            this.lblMateria.TabIndex = 2;
            this.lblMateria.Text = "Materia - ";
            this.lblMateria.Click += new System.EventHandler(this.metodo_Click);
            // 
            // lblOrientacion
            // 
            this.lblOrientacion.AutoSize = true;
            this.lblOrientacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrientacion.Location = new System.Drawing.Point(299, 9);
            this.lblOrientacion.Name = "lblOrientacion";
            this.lblOrientacion.Size = new System.Drawing.Size(118, 24);
            this.lblOrientacion.TabIndex = 3;
            this.lblOrientacion.Text = "Orientación -";
            this.lblOrientacion.Click += new System.EventHandler(this.metodo_Click);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(434, 9);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(74, 24);
            this.lblGrupo.TabIndex = 4;
            this.lblGrupo.Text = "Grupo -";
            this.lblGrupo.Click += new System.EventHandler(this.metodo_Click);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.Location = new System.Drawing.Point(514, 9);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(87, 24);
            this.lblAlumno.TabIndex = 5;
            this.lblAlumno.Text = "Alumno -";
            this.lblAlumno.Click += new System.EventHandler(this.metodo_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(708, 11);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(126, 24);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Consulta/Chat";
            this.lblTipo.Click += new System.EventHandler(this.metodo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FORPanelChatsConsultasPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(850, 49);
            this.ControlBox = false;
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblOrientacion);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblDocente);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORPanelChatsConsultasPrincipal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FORPanelChatsConsultasPrincipal";
            this.Load += new System.EventHandler(this.FORPanelChatsConsultasPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblOrientacion;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblTipo;
    }
}