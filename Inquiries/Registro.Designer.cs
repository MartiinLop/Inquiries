
namespace Inquiries
{
    partial class Registro
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.RegDoc = new System.Windows.Forms.Button();
            this.RegAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(1084, 604);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(168, 47);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // RegDoc
            // 
            this.RegDoc.BackColor = System.Drawing.Color.White;
            this.RegDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegDoc.Location = new System.Drawing.Point(341, 345);
            this.RegDoc.Name = "RegDoc";
            this.RegDoc.Size = new System.Drawing.Size(583, 69);
            this.RegDoc.TabIndex = 8;
            this.RegDoc.Text = "Registrarse cómo docente";
            this.RegDoc.UseVisualStyleBackColor = false;
            this.RegDoc.Click += new System.EventHandler(this.RegDoc_Click);
            // 
            // RegAl
            // 
            this.RegAl.BackColor = System.Drawing.Color.White;
            this.RegAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegAl.Location = new System.Drawing.Point(341, 248);
            this.RegAl.Name = "RegAl";
            this.RegAl.Size = new System.Drawing.Size(583, 69);
            this.RegAl.TabIndex = 7;
            this.RegAl.Text = "Registrarse cómo alumno";
            this.RegAl.UseVisualStyleBackColor = false;
            this.RegAl.Click += new System.EventHandler(this.RegAl_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1264, 663);
            this.Controls.Add(this.RegDoc);
            this.Controls.Add(this.RegAl);
            this.Controls.Add(this.btnVolver);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button RegDoc;
        private System.Windows.Forms.Button RegAl;
    }
}