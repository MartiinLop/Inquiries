
namespace Inquiries
{
    partial class MenuPrincipal
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
            this.btnSalirPrincipal = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnInSesión = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirPrincipal
            // 
            this.btnSalirPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnSalirPrincipal.Cursor = System.Windows.Forms.Cursors.No;
            this.btnSalirPrincipal.FlatAppearance.BorderSize = 0;
            this.btnSalirPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirPrincipal.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSalirPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnSalirPrincipal.Location = new System.Drawing.Point(941, 542);
            this.btnSalirPrincipal.Name = "btnSalirPrincipal";
            this.btnSalirPrincipal.Size = new System.Drawing.Size(220, 57);
            this.btnSalirPrincipal.TabIndex = 2;
            this.btnSalirPrincipal.Text = "Cerrar programa";
            this.btnSalirPrincipal.UseVisualStyleBackColor = false;
            this.btnSalirPrincipal.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Roboto", 24F);
            this.btnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarse.Location = new System.Drawing.Point(293, 480);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(583, 69);
            this.btnRegistrarse.TabIndex = 1;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInSesión
            // 
            this.btnInSesión.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnInSesión.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInSesión.FlatAppearance.BorderSize = 0;
            this.btnInSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInSesión.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInSesión.ForeColor = System.Drawing.Color.White;
            this.btnInSesión.Location = new System.Drawing.Point(293, 382);
            this.btnInSesión.Name = "btnInSesión";
            this.btnInSesión.Size = new System.Drawing.Size(583, 69);
            this.btnInSesión.TabIndex = 0;
            this.btnInSesión.Text = "Iniciar sesión";
            this.btnInSesión.UseVisualStyleBackColor = false;
            this.btnInSesión.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnInSesión);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnRegistrarse);
            this.panel2.Controls.Add(this.btnSalirPrincipal);
            this.panel2.Font = new System.Drawing.Font("Amiri Quran", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel2.Location = new System.Drawing.Point(34, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 620);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Inquiries.Properties.Resources.lutu;
            this.pictureBox2.Location = new System.Drawing.Point(145, 499);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Inquiries.Properties.Resources.wok2;
            this.pictureBox1.Location = new System.Drawing.Point(27, 499);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Inquiries.Properties.Resources.inquiries;
            this.panel1.Location = new System.Drawing.Point(449, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 271);
            this.panel1.TabIndex = 4;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Name = "MenuPrincipal";
            this.Text = "Menú Principal";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalirPrincipal;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnInSesión;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

