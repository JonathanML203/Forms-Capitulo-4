namespace Capitulo3_TADP
{
    partial class Prac4
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
            this.btnObtenerDia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPrimos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnObtenerDia
            // 
            this.btnObtenerDia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnObtenerDia.Location = new System.Drawing.Point(259, 208);
            this.btnObtenerDia.Name = "btnObtenerDia";
            this.btnObtenerDia.Size = new System.Drawing.Size(121, 50);
            this.btnObtenerDia.TabIndex = 5;
            this.btnObtenerDia.Text = "Calcular";
            this.btnObtenerDia.UseVisualStyleBackColor = true;
            this.btnObtenerDia.Click += new System.EventHandler(this.btnObtenerDia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hacer un programa que encuentre los números \r\nprimos que existen entre el 1 y el " +
    "1000.";
            // 
            // lstPrimos
            // 
            this.lstPrimos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPrimos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrimos.FormattingEnabled = true;
            this.lstPrimos.ItemHeight = 23;
            this.lstPrimos.Location = new System.Drawing.Point(565, 25);
            this.lstPrimos.Name = "lstPrimos";
            this.lstPrimos.Size = new System.Drawing.Size(205, 345);
            this.lstPrimos.TabIndex = 27;
            // 
            // Prac4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPrimos);
            this.Controls.Add(this.btnObtenerDia);
            this.Controls.Add(this.label1);
            this.Name = "Prac4";
            this.Text = "Prac4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnObtenerDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPrimos;
    }
}