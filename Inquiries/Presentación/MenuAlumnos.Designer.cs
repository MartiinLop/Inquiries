﻿
namespace Inquiries
{
    partial class MenuAlumnos
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPerfilDoc = new System.Windows.Forms.Button();
            this.btnCerrarAl = new System.Windows.Forms.Button();
            this.btnChatAl = new System.Windows.Forms.Button();
            this.btnConsultasAl = new System.Windows.Forms.Button();
            this.btnGruposAl = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(8, 154);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1599, 626);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 160);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1653, 74);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTIFICACIONES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnPerfilDoc);
            this.panel1.Controls.Add(this.btnCerrarAl);
            this.panel1.Controls.Add(this.btnChatAl);
            this.panel1.Controls.Add(this.btnConsultasAl);
            this.panel1.Controls.Add(this.btnGruposAl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1685, 150);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1279, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnPerfilDoc
            // 
            this.btnPerfilDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfilDoc.FlatAppearance.BorderSize = 0;
            this.btnPerfilDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfilDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfilDoc.Location = new System.Drawing.Point(1477, 5);
            this.btnPerfilDoc.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnPerfilDoc.Name = "btnPerfilDoc";
            this.btnPerfilDoc.Size = new System.Drawing.Size(188, 138);
            this.btnPerfilDoc.TabIndex = 6;
            this.btnPerfilDoc.Text = "Perfil";
            this.btnPerfilDoc.UseVisualStyleBackColor = true;
            this.btnPerfilDoc.Click += new System.EventHandler(this.btnPerfilDoc_Click);
            // 
            // btnCerrarAl
            // 
            this.btnCerrarAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarAl.FlatAppearance.BorderSize = 0;
            this.btnCerrarAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarAl.Location = new System.Drawing.Point(764, 6);
            this.btnCerrarAl.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnCerrarAl.Name = "btnCerrarAl";
            this.btnCerrarAl.Size = new System.Drawing.Size(271, 138);
            this.btnCerrarAl.TabIndex = 5;
            this.btnCerrarAl.Text = "Cerrar sesión";
            this.btnCerrarAl.UseVisualStyleBackColor = true;
            this.btnCerrarAl.Click += new System.EventHandler(this.btnCerrarAl_Click);
            // 
            // btnChatAl
            // 
            this.btnChatAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChatAl.FlatAppearance.BorderSize = 0;
            this.btnChatAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChatAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChatAl.Location = new System.Drawing.Point(560, 6);
            this.btnChatAl.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnChatAl.Name = "btnChatAl";
            this.btnChatAl.Size = new System.Drawing.Size(188, 138);
            this.btnChatAl.TabIndex = 2;
            this.btnChatAl.Text = "CHAT";
            this.btnChatAl.UseVisualStyleBackColor = true;
            this.btnChatAl.Click += new System.EventHandler(this.btnChatAl_Click);
            // 
            // btnConsultasAl
            // 
            this.btnConsultasAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultasAl.FlatAppearance.BorderSize = 0;
            this.btnConsultasAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultasAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultasAl.Location = new System.Drawing.Point(256, 6);
            this.btnConsultasAl.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnConsultasAl.Name = "btnConsultasAl";
            this.btnConsultasAl.Size = new System.Drawing.Size(316, 138);
            this.btnConsultasAl.TabIndex = 1;
            this.btnConsultasAl.Text = "CONSULTAS";
            this.btnConsultasAl.UseVisualStyleBackColor = true;
            this.btnConsultasAl.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnGruposAl
            // 
            this.btnGruposAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGruposAl.FlatAppearance.BorderSize = 0;
            this.btnGruposAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGruposAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGruposAl.Location = new System.Drawing.Point(8, 6);
            this.btnGruposAl.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnGruposAl.Name = "btnGruposAl";
            this.btnGruposAl.Size = new System.Drawing.Size(256, 138);
            this.btnGruposAl.TabIndex = 0;
            this.btnGruposAl.Text = "GRUPOS";
            this.btnGruposAl.UseVisualStyleBackColor = true;
            this.btnGruposAl.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // MenuAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuAlumnos";
            this.Text = "Menu de Alumnos";
            this.Load += new System.EventHandler(this.MenuAlumnos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChatAl;
        private System.Windows.Forms.Button btnConsultasAl;
        private System.Windows.Forms.Button btnGruposAl;
        private System.Windows.Forms.Button btnCerrarAl;
        private System.Windows.Forms.Button btnPerfilDoc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}