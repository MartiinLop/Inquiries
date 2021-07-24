
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSalirPrincipal
            // 
            this.btnSalirPrincipal.BackColor = System.Drawing.Color.White;
            this.btnSalirPrincipal.Cursor = System.Windows.Forms.Cursors.No;
            this.btnSalirPrincipal.FlatAppearance.BorderSize = 0;
            this.btnSalirPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirPrincipal.Location = new System.Drawing.Point(1032, 612);
            this.btnSalirPrincipal.Name = "btnSalirPrincipal";
            this.btnSalirPrincipal.Size = new System.Drawing.Size(220, 57);
            this.btnSalirPrincipal.TabIndex = 2;
            this.btnSalirPrincipal.Text = "Cerrar programa";
            this.btnSalirPrincipal.UseVisualStyleBackColor = false;
            this.btnSalirPrincipal.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.White;
            this.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.Location = new System.Drawing.Point(359, 481);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(583, 69);
            this.btnRegistrarse.TabIndex = 1;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInSesión
            // 
            this.btnInSesión.BackColor = System.Drawing.Color.White;
            this.btnInSesión.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInSesión.FlatAppearance.BorderSize = 0;
            this.btnInSesión.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInSesión.Location = new System.Drawing.Point(359, 389);
            this.btnInSesión.Name = "btnInSesión";
            this.btnInSesión.Size = new System.Drawing.Size(583, 69);
            this.btnInSesión.TabIndex = 0;
            this.btnInSesión.Text = "Iniciar sesión";
            this.btnInSesión.UseVisualStyleBackColor = false;
            this.btnInSesión.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Inquiries.Properties.Resources.wok;
            this.panel1.Location = new System.Drawing.Point(497, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 343);
            this.panel1.TabIndex = 4;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInSesión);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnSalirPrincipal);
            this.Name = "MenuPrincipal";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalirPrincipal;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnInSesión;
        private System.Windows.Forms.Panel panel1;
    }
}

