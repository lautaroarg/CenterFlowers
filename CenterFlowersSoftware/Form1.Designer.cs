﻿namespace CenterFlowersSoftware
{
    partial class frmMenu
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
            this.btnUsuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(12, 103);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(146, 40);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Provedores";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Mercaderia";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Estadistica";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Mercaderia provista";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 422);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUsuario);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

