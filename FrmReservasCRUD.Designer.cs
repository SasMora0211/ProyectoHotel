using System;

namespace Presentacion
{
    partial class FrmReservasCRUD
    {
        
        private System.ComponentModel.IContainer components = null;

        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservasCRUD));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear reserva";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(316, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Eliminar reserva";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(341, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(316, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modificar reserva";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmReservasCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(988, 616);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmReservasCRUD";
            this.Text = "FrmReservasCRUD";
            this.Load += new System.EventHandler(this.FrmReservasCRUD_Load);
            this.ResumeLayout(false);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}